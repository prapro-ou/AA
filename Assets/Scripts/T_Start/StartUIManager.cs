using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUIManager : MonoBehaviour
{
  [SerializeField] GameObject GuideText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void DisplayGuide() {
      GuideText.SetActive(true);
    }

    public void HideGuide() {
      GuideText.SetActive(false);
    }
}
