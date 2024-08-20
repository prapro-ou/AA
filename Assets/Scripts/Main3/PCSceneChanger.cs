using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCSceneChanger : MonoBehaviour
{
    [SerializeField] string pc_password_scene_name;
    [SerializeField] string keyboard_scene_name;
    [SerializeField] string desktop_scene_name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePCScene() {
        string scene_name;

        if (ActionSceneData.IsCleared(keyboard_scene_name)) {
            scene_name = desktop_scene_name;
        }
        else if (ActionSceneData.IsCleared(pc_password_scene_name)) {
            scene_name = keyboard_scene_name;
        }
        else {
            scene_name = pc_password_scene_name;
        }

        Debug.Log("PC Scene is " + scene_name);

        SceneManager.LoadScene(scene_name);
    }
}
