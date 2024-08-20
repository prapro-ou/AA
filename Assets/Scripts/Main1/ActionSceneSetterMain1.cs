using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSceneSetterMain1 : MonoBehaviour
{
    [SerializeField] GameObject Locker;
    [SerializeField] GameObject MatchPuzzle;
    [SerializeField] GameObject Drawer;
    // Start is called before the first frame update
    void Start()
    {
        if (ActionSceneData.IsCleared("Locker")) Locker.SetActive(false);

        if (ActionSceneData.IsCleared("MatchPuzzle")) MatchPuzzle.SetActive(false);

        if (ActionSceneData.IsCleared("Drawer")) Drawer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
