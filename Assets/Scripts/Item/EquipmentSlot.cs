using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot 
{
    public BaseItem item;
    public GameObject icon;
    public ItemLocation location;
    public void UpdateSlot()
    {
        if (item != null)
        {
            icon.GetComponent<Image>().sprite = item.Sprite;
            icon.SetActive(true);
        }
        else
        {
            icon.SetActive(false);
        }
    }
}
