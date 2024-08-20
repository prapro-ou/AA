using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class A_PCPassWordManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI inPWText;
    private int pwColumn = 0;
    private string[] pwArray = new string[7];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PressKeyButton(string inKey)
    {
        if (inKey == "back")
        {
            PWClear();
        }
        else if (inKey == "enter")
        {
            if (string.Join("", pwArray) == "TANUKI")
            {
                Debug.Log("Clear!");
                SceneManager.LoadScene("Desktop");
            }
            else
            {
                Debug.Log("Wrong!");
            }
        }
        else
        {
             if (pwColumn < 6)
            {
                pwArray[pwColumn] = inKey;
                inPWText.text = string.Join("", pwArray);
                pwColumn++;
            }
            else if (pwColumn == 6)
            {
                PWClear();
            } 
        }
    }

    private void PWClear()
    {
        for (int i = 0; i < pwArray.Length; i++)
        {
            pwArray[i] = "";
        }
            inPWText.text = string.Join("", pwArray);  
            pwColumn = 0;      
    }
}
