using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    private QuizManager quizManager;

    private void Start()
    {
        quizManager = FindObjectOfType<QuizManager>();
        if (quizManager == null)
        {
            Debug.LogError("QuizManager not found!");
        }
    }

    public void AnswerSelected()
    {
        if (quizManager != null)
        {
            if (isCorrect)
            {
                quizManager.correct();
            }
            else
            {
                quizManager.wrong();
            }
        }
        else
        {
            Debug.LogError("QuizManager is not assigned in Answer script.");
        }
    }
}
