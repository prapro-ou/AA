using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public GameObject[] options;
    public TextMeshProUGUI QuestionText;
    public TextMeshProUGUI resultText;
    public TMP_FontAsset japaneseFont;
    public GameObject resultPanel;
    public GameObject retryButton;
    public Image resultImage;
    public Sprite ItemImage;

    private string question;
    private string[] answers;
    private int correctAnswer;

    void Start()
    {
        question = "以下の反転時計の時間の合計を求めよ．";
        answers = new string[] { "18時20分", "18時30分", "19時15分", "19時20分", "19時15分", "19時30分"};
        correctAnswer = 4;

        makeQuestion();
    }

    void makeQuestion()
    {
        QuestionText.text = question;
        QuestionText.font = japaneseFont;
        setAnswer();
        resultPanel.SetActive(false);  // 결과 패널 숨기기
    }

    void setAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            if (options[i] == null)
            {
                Debug.LogError($"Option {i} is not assigned.");
                continue;
            }

            options[i].GetComponent<Answer>().isCorrect = false;

            TextMeshProUGUI optionText = options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            if (optionText == null)
            {
                Debug.LogError($"Option {i} does not have a TextMeshProUGUI component.");
                continue;
            }

            optionText.text = answers[i];
            optionText.font = japaneseFont;

            if (correctAnswer == i + 1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }

    public void correct()
    {
        resultText.text = "正解!";
        resultPanel.SetActive(true);  // 결과 패널 표시
        retryButton.SetActive(false);  // 다시 시도 버튼 숨기기
        resultImage.sprite = ItemImage;
        resultImage.gameObject.SetActive(true);
    }

    public void wrong()
    {
        resultText.text = "不正解.";
        resultPanel.SetActive(true);  // 결과 패널 표시
        retryButton.SetActive(true);  // 다시 시도 버튼 표시
        resultImage.gameObject.SetActive(false);
    }

    public void RetryQuiz()
    {
        makeQuestion();
    }
}