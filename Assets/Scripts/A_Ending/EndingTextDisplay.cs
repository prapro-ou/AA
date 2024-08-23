using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingTextDisplay : MonoBehaviour
{
    public string[] texts;
    int textNumber=0;
    AudioSource audioSource;
    public AudioClip lockDoor;
    public AudioClip help;
    int textCharNumber;
    string displayText;

    [SerializeField] GameObject blood;

    int i;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(Narration());
         audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Narration()
    {
        while (textNumber != texts.Length-1)
        {
            this.GetComponent<Text>().text = texts[textNumber];

            if (textNumber==5)
            {
                 StartCoroutine(loop(help));  
            }

            yield return new WaitForSeconds(4.0f); 
            this.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(2.0f); 
            
            if (textNumber==2)
            {
                StartCoroutine(loop(lockDoor)); 
                yield return new WaitForSeconds(4.0f);   
            }

            textNumber = textNumber + 1;              
        }
            while (textCharNumber != texts[textNumber].Length)
            {
                displayText = displayText + texts[textNumber][textCharNumber];
                yield return new WaitForSeconds(1.0f);
                textCharNumber = textCharNumber + 1;
                this.GetComponent<Text>().text = displayText;
            } 
            yield return new WaitForSeconds(2.0f);   
            blood.SetActive(true);
    }

    private IEnumerator loop(AudioClip sound)
    {
        for(i=0; i<2; i++)
        {
            audioSource.clip = sound;
            audioSource.Play();  
            yield return new WaitForSeconds(2.0f); 
        }
    }
}
