using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTextDisplay : MonoBehaviour
{
    public string[] texts;
    int textNumber=0;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(Narration());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Narration()
    {
        yield return new WaitForSeconds(4.0f); 
        while (textNumber != texts.Length)
        {
            this.GetComponent<Text>().text = texts[textNumber];
            yield return new WaitForSeconds(4.0f); 
            this.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(2.0f); 
            textNumber = textNumber + 1; 
        }
    }
}
