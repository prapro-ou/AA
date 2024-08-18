using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenItemPanelManager : MonoBehaviour
{
    [SerializeField] GameObject GotItemWindow;

    [SerializeField] GameObject ItemGetButton;
    [SerializeField] string item_name;
    // Start is called before the first frame update
    void Start()
    {
        if (ItemData.IsAdded(item_name)) {
            ItemGetButton.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveItemWindow() {
        GotItemWindow.SetActive(true);
        ItemGetButton.SetActive(false);
    }

    public void DestroyItemWindow () {
        GotItemWindow.SetActive(false);
    }
}
