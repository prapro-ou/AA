using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUIManager : MonoBehaviour
{
    [SerializeField] GameObject ItemBoxPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenItemBox() {
      ItemBoxPanel.SetActive(true);
    }
    public void CloseItemBox() {
      ItemBoxPanel.SetActive(false);
    }
}
