using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSceneSetterMain2 : MonoBehaviour
{
    [SerializeField] GameObject Clock;
    [SerializeField] GameObject Puzzle8;
    // Start is called before the first frame update
    void Start()
    {
        if (ActionSceneData.IsCleared("SampleScene")) Clock.SetActive(false);

        if (ActionSceneData.IsCleared("Puzzle8")) Puzzle8.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
