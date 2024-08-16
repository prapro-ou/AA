using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_KeyManager : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject N;
    [SerializeField] GameObject R;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if(ItemData.GetHoldItemName()==KeyName) {
            GetItemObject(KeyName).SetActive(false);

            Debug.Log("Remove!");
        }

    }
}
