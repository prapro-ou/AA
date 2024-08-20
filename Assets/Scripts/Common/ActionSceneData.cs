using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSceneData : MonoBehaviour 
{
    private static List<string> action_scene_list 
    = new List<string>() {
        "Drawer",
        "EscapeDoor",
        "Locker",
        "MatchPuzzle",
        "pc_Waitingpassword",
        "Puzzle8",
        "SampleScene",
        "BrokenKeyBoardScene",
        "KeyBoardScene"
    };
    private static List<string> cleared_scene_name = new List<string>();

    public static bool IsCleared(string scene_name) {
        return cleared_scene_name.Contains(scene_name);
    }

    public static bool Contains (string scene_name) {
        return action_scene_list.Contains(scene_name);
    }
    // Start is called before the first frame update

    public static void ClearScene(string scene_name) {
        if (action_scene_list.Contains(scene_name)) {
            Debug.Log("Delete Scene " + scene_name);
            cleared_scene_name.Add(scene_name);
        }
    }

}
