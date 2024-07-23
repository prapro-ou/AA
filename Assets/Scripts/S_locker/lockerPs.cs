using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lockerPs : MonoBehaviour
{
    public GameObject EnterText;
    public GameObject Textbackground;
    public GameObject background;
    public InputField inputField;
    public GameObject input; 
    public GameObject Key_image;
    public GameObject KeyText;
    string answer = "ひらけとびら";

    // Start is called before the first frame update
    void Start()
    {
        inputField =  inputField.GetComponent<InputField> ();
        //Debug.Log("問題なし");
    }

    public void OnClick()
    {
        EnterText.SetActive(false);
        Textbackground.SetActive(false);
        background.SetActive(true);
        input.SetActive(true);
    }

    public void GetInput()
    {
        string name = inputField.text;
        Debug.Log(name);
        if (string.Compare(name, answer, ignoreCase:true) == 0)
        {
            //Debug.Log("クリア！！");
            Key_image.SetActive(true);
            KeyText.SetActive(true);
            input.SetActive(false);

        }
        else
        {
            //Debug.Log("間違い");
        }
    }
}
