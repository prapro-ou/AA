using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_KeyManager : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject N;
    [SerializeField] GameObject R;

    private static bool key_A_is_used = false;

    private static bool key_N_is_used = false;

    private static bool key_R_is_used = false;

    // Start is called before the first frame update
    void Start()
    {
        if (key_A_is_used) A.SetActive(false);

        if (key_N_is_used) N.SetActive(false);

        if (key_R_is_used) R.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (!A.activeSelf && !R.activeSelf && !N.activeSelf) {
            ActionSceneData.ClearScene("pc_Waitingpassword");
            ActionSceneData.ClearScene("BrokenKeyBoardScene");
            SceneManager.LoadScene("KeyBoardScene");   
        }
    }

    private GameObject GetItemObject(string KeyName) {
        switch (KeyName) {
            case "KEY_A":
             return A;
            case "KEY_N":
             return N;
            case "KEY_R":
             return R;
            default:
             return null;
        }
    }
    public void RemoveBlind(string KeyName)
    {
        if(KeyName.Equals(ItemData.GetHoldItemName())) {
            GetItemObject(KeyName).SetActive(false);

            switch (KeyName) {
                case "KEY_A": {
                    key_A_is_used = true;
                    break;
                }
                case "KEY_N": {
                    key_N_is_used = true;
                    break;
                }
                case "KEY_R": {
                    key_R_is_used = true;
                    break;
                }
            }

            Debug.Log("Remove!");
        }

    }
}
