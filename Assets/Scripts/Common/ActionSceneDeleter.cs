using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSceneDeleter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClearScene(string scene_name) {
        if (ActionSceneData.Contains(scene_name)) {
            ActionSceneData.ClearScene(scene_name);
            Debug.Log("Clear " + scene_name);
        }
    }
}
