using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanelManager : MonoBehaviour
{
    [SerializeField] GameObject ItemBoxPanel;
    [SerializeField] GameObject ItemDetailPanel;
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

    public void OpenItemDetailPanel() {
      if (ItemData.GetHoldItemName() != null) {
        ItemDetailPanel.SetActive(true);
      }
    }

    public void CloseItemDetailPanel() {
      ItemDetailPanel.SetActive(false);
    }
}
