using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button transparentButton;
    public GameObject whitePanel;

    void Start()
    {
        transparentButton.onClick.AddListener(ShowWhitePanel);
        whitePanel.SetActive(false);
    }

    void ShowWhitePanel()
    {
        whitePanel.SetActive(true);
    }
}