using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemData : MonoBehaviour
{
  [SerializeField] GameObject HoldItemImage;
  [SerializeField] GameObject HoldItemDetailImage;
  [SerializeField] GameObject EmptyImage;
  [SerializeField] GameObject KEY_A;
  [SerializeField] GameObject KEY_N;
  [SerializeField] GameObject KEY_R;
  [SerializeField] GameObject KEY;
  [SerializeField] GameObject ASCII_TABLE;
  [SerializeField] GameObject STACK_MEMO;
  [SerializeField] GameObject LOGIC_MEMO;

  private static List<string> item_list = new List<string>();

  private static string hold_item_name = null;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < item_list.Count; i++) {
          GetItemObject(item_list[i]).SetActive(true);
        }

        if (hold_item_name != null) {
          HoldItemImage.GetComponent<Image>().sprite = GetItemObject(hold_item_name).GetComponent<Image>().sprite; 
          HoldItemDetailImage.GetComponent<Image>().sprite = GetItemObject(hold_item_name).GetComponent<Image>().sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject GetItemObject(string item_name) {
      switch (item_name) {
        case "KEY_A":
          return KEY_A;
        case "KEY_N":
          return KEY_N;
        case "KEY_R":
          return KEY_R;
        case "KEY":
          return KEY;
        case "ASCII_TABLE":
          return ASCII_TABLE;
        case "STACK_MEMO":
          return STACK_MEMO;
        case "LOGIC_MEMO":
          return LOGIC_MEMO;
        default:
          return null;
      }
    }

    // 現在ホールドしているアイテムの名前の取得
    public static string GetHoldItemName() {
      return hold_item_name;
    }

    public static bool Contains(string item_name) {
      if (item_list.Contains(item_name)) 
        return true;
      else 
        return false;
    }

    // ボックスへのアイテムの追加
    public void AddItem(string item_name) {
      if (GetItemObject(item_name) == null) return;
      
      for (int i = 0; i < item_list.Count; i++) {
        if (item_list.Contains(item_name)) return;
      }

      item_list.Add(item_name);
      GetItemObject(item_name).SetActive(true);

      Debug.Log("Get item!");
    }

    // ホールド状態のアイテムの選択 [Button Click]
    public void SelectItem(string item_name) {
      if (GetItemObject(item_name) == null) return;  

      hold_item_name = item_name;

      HoldItemImage.GetComponent<Image>().sprite = GetItemObject(item_name).GetComponent<Image>().sprite; 
      HoldItemDetailImage.GetComponent<Image>().sprite = GetItemObject(item_name).GetComponent<Image>().sprite;

      Debug.Log("Select item!");
    }

    // アイテムの使用 [Button Click]
    public void UseItem(string item_name) {
      if (item_name == hold_item_name) {
        item_list.Remove(item_name);
        hold_item_name = null;
        
        GetItemObject(item_name).SetActive(false);
        HoldItemImage.GetComponent<Image>().sprite = EmptyImage.GetComponent<Image>().sprite;
        HoldItemDetailImage.GetComponent<Image>().sprite = null;

        Debug.Log("Use item!");
      }
    }

}
