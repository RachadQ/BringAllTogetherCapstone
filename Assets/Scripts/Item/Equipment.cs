using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public BaseItem[] equipItem = new BaseItem[7];
    public EquipmentSlot[] inventorySlots;
    public bool Equip(BaseItem item)
    {
        for (int i = 0; i < equipItem.Length; i++)
        {
            if (equipItem[i] == null)
            {

            }
        }
        return false;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
