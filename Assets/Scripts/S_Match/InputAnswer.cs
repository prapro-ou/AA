using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputAnswer : MonoBehaviour
{
    private AudioSource audioSource; // オーディオソース
    public AudioClip timeUpSound; // タイムアップの音
    public InputField inputField;
    public GameObject input;
    public GameObject memo_image;
    public GameObject memo;
    string answer = "43->113";
    // Start is called before the first frame update
    void Start()
    {
        inputField =  inputField.GetComponent<InputField> ();
        audioSource = this.gameObject.GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(timeUpSound);
            input.SetActive(false);

        }
        else
        {
            Debug.Log("間違い");
        }
    }
}
