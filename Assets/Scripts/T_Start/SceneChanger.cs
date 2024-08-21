using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
using TMPro;

public class SceneChange: MonoBehaviour
{
  public Image fadePanel;

  [SerializeField] GameObject StartButton;
  [SerializeField] GameObject GuideText;

  [SerializeField] private string sceneName;
  [SerializeField] private float fadeDuration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toMainScene() {
      Debug.Log("Clicked!");
      StartButton.SetActive(false);
      GuideText.SetActive(false);
      StartCoroutine(SceneBlackout());
    }

    private IEnumerator SceneBlackout() {
      fadePanel.enabled = true;
      float elapsedTime = 0.0f;
      Color startColor = fadePanel.color;
      Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1.0f);

      while (elapsedTime < fadeDuration) {
        elapsedTime += Time.deltaTime;
        float t = Mathf.Clamp01(elapsedTime / fadeDuration);
        fadePanel.color = Color.Lerp(startColor, endColor, t);
        yield return null;;
      }

      fadePanel.color = endColor;
      SceneManager.LoadScene(sceneName);
    }
}
