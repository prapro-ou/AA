using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASCII_Manager : MonoBehaviour
{
    [SerializeField] GameObject ASCIIGetPanel;

    [SerializeField] GameObject HiddenASCIIPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveASCIIWindow() {
        ASCIIGetPanel.SetActive(true);
        HiddenASCIIPanel.SetActive(false);
    }

    public void DestroyASCIIWindow () {
        ASCIIGetPanel.SetActive(false);
    }
}
