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
    public Button resultButton;
    public Sprite ItemImage;

    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    private string question;
    private string[] answers;
    private int correctAnswer;

    void Start()
    {        
        question = "以下の反転時計の時間の合計を求めよ．";
        answers = new string[] { "18時20分", "18時30分", "19時15分", "19時20分", "19時15分", "19時30分"};
        correctAnswer = 3;

        makeQuestion();

        resultPanel.SetActive(false);
        retryButton.SetActive(false);

        resultButton.onClick.AddListener(HideResultButton);
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
            Button optionButton = options[i].GetComponent<Button>();
            optionButton.onClick.RemoveAllListeners(); // 기존 리스너 제거

            options[i].GetComponent<Answer>().isCorrect = false;

            TextMeshProUGUI optionText = options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>();

            optionText.text = answers[i];
            optionText.font = japaneseFont;

            if (correctAnswer == i)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
                optionButton.onClick.AddListener(() => HandleAnswer(true));
            }
            else
            {
                optionButton.onClick.AddListener(() => HandleAnswer(false));
            }
        }
    }

    private void HandleAnswer(bool isCorrect)
    {
        if (isCorrect)
        {
            resultText.text = "正解!";
            resultButton.image.sprite = ItemImage;
            resultButton.gameObject.SetActive(true);
            PlayCorrectSound();
        }
        else
        {
            resultText.text = "不正解.";
            resultButton.gameObject.SetActive(false);
            PlayWrongSound();
        }

        resultPanel.SetActive(true);  // 결과 패널 표시
        retryButton.SetActive(isCorrect ? false : true);  // 정답일 경우 Retry 버튼 숨기기
    }

    public void RetryQuiz()
    {
        resultPanel.SetActive(false);
        retryButton.SetActive(false);

        makeQuestion();
    }

    private void HideResultButton()
    {
        resultButton.gameObject.SetActive(false);
    }

    private void PlayCorrectSound()
    {
        if (audioSource != null && correctSound != null)
        {
            audioSource.clip = correctSound;
            audioSource.Play();
        }
    }

    private void PlayWrongSound()
    {
        if (audioSource != null && wrongSound != null)
        {
            audioSource.clip = wrongSound;
            audioSource.Play();
        }
    }
}