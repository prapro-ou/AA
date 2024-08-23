using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorTextDisplay : MonoBehaviour
{
    public string[] texts;
    int textNumber=0;

    public GameObject fadePanel;

    public string next_scene_name;

    [SerializeField] private float fadeDuration = 1.0f;

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

        fadePanel.SetActive(true);

        Color fade_color = fadePanel.GetComponent<Image>().color;
        int count = 0;

        float delta_time = fadeDuration / 255;
        float delta_alpha = 1.0f / 255;

        while (count <= 255) {
          fade_color.a += delta_alpha;
          fadePanel.GetComponent<Image>().color = fade_color;
          yield return new WaitForSeconds(delta_time); 
          count++;
        }

        SceneManager.LoadScene(next_scene_name);
    }
}
