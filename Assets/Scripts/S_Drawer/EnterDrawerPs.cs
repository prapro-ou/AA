using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterDrawerPs : MonoBehaviour
{
    public InputField inputField;
    public GameObject input;
    public GameObject image;
    public GameObject Key_image;
    public GameObject TextMessage;
    public GameObject GetMessage;
    string answer = "1949";

    // Start is called before the first frame update
    void Start()
    {
        inputField =  inputField.GetComponent<InputField> ();
    }

    public void GetInput()
    {
        string name = inputField.text;
        //Debug.Log(name);
        if (string.Compare(name, answer, ignoreCase:true) == 0)
        {
            //Debug.Log("クリア！！");
            TextMessage.SetActive(false);
            GetMessage.SetActive(true);
            Key_image.SetActive(true);
            input.SetActive(false);

        }
        else
        {
            //Debug.Log("間違い");
        }
    }
}
