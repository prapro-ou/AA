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
}