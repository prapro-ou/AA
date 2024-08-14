using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputAnswer : MonoBehaviour
{
    public InputField inputField;
    public GameObject memo_image;
    public GameObject memo;
    string answer = "43->113";
    // Start is called before the first frame update
    void Start()
    {
        inputField =  inputField.GetComponent<InputField> ();
       // Debug.Log("問題なし");
    }

    public void GetInput()
    {
        string name = inputField.text;
        Debug.Log(name);
        if (string.Compare(name, answer, ignoreCase:true) == 0)
        {
            //Debug.Log("クリア！！");
            memo.SetActive(true);
            memo_image.SetActive(true);

        }
        else
        {
            Debug.Log("間違い");
        }
    }
}
