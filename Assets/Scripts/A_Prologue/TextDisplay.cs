using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDisplay : MonoBehaviour
{
    public string[] texts;
    int textNumber=0;
    string displayText;
    int textCharNumber;

    AudioSource audioSource;
    public AudioClip door;
    public AudioClip key;

    public string next_scene_name;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Narration());
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private IEnumerator Narration()
    {
        yield return new WaitForSeconds(5.0f); 
        displayText = texts[0];
        Display();
        Reset();
        yield return new WaitForSeconds(3.0f); 
        Display(); 
        yield return new WaitForSeconds(3.0f); 
        
        while (textNumber != texts.Length)
        {   
           
             while (textCharNumber != texts[textNumber].Length)
             {
                displayText = displayText + texts[textNumber][textCharNumber];
                yield return new WaitForSeconds(0.2f);
                textCharNumber = textCharNumber + 1;
                Display();
             }    
            
            textCharNumber = 0;
            Reset();
            yield return new WaitForSeconds(3.0f); 
                          
        }
        audioSource.clip = door;
        audioSource.Play();
         yield return new WaitForSeconds(3.0f); 
        audioSource.clip = key;
        audioSource.Play();
        yield return new WaitForSeconds(0.3f); 
        this.gameObject.SetActive(false);
        
        SceneManager.LoadScene(next_scene_name);
    }

    private void Reset()
    {
        displayText = "";
        textNumber = textNumber + 1;      
    }

    private void Display()
    {
        this.GetComponent<Text>().text = displayText;
    }
}
