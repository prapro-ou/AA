using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneChanger : MonoBehaviour
{
  public string ending_scene_name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toEndingScene() {
      if (ItemData.IsUsed("KEY")) {
        SceneManager.LoadScene(ending_scene_name);
      }
    }
}
