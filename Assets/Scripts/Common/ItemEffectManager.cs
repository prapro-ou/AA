using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemEffectManager : MonoBehaviour
{
    [SerializeField] GameObject EffectImage;

    [SerializeField] float blink_duration;
    private float delta_alpha;

    private Color efftct_color;

    private int sign = 1;
    // Start is called before the first frame update
    void Start()
    {
        efftct_color = EffectImage.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        efftct_color = EffectImage.GetComponent<Image>().color;

        delta_alpha = (Time.deltaTime / blink_duration) * sign;

        efftct_color.a += delta_alpha;

        if (efftct_color.a < 0.0f) {
            efftct_color.a = 0.0f;
            sign = 1;
        }
        else if (efftct_color.a > 1.0f) {
            efftct_color.a = 1.0f;
            sign = -1;
        }

        EffectImage.GetComponent<Image>().color = efftct_color;

    }
}
