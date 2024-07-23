using UnityEngine;
using UnityEngine.UI;

public class ImagePanelManager : MonoBehaviour
{
    public GameObject watchImagePanel1; 
    public GameObject watchImagePanel2;
    public Sprite watchImage1; 
    public Sprite watchImage2; 
    public Vector2 watchImage1Size = new Vector2(200, 200);
    public Vector2 watchImage2Size = new Vector2(200, 200);

    void Start()
    {
        AddImageToPanel(watchImagePanel1, watchImage1, watchImage1Size);
        AddImageToPanel(watchImagePanel2, watchImage2, watchImage2Size);
    }

    void AddImageToPanel(GameObject panel, Sprite imageSprite, Vector2 imageSize)
    {
        Image imageComponent = panel.GetComponent<Image>();
        if (imageComponent == null)
        {
            imageComponent = panel.AddComponent<Image>();
        }

        imageComponent.sprite = imageSprite;

        RectTransform rectTransform = panel.GetComponent<RectTransform>();
        rectTransform.sizeDelta = imageSize;
    }
}

