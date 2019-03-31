using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class LootTable 
{
    [SerializeField]
    private Loot[] loot;
    [SerializeField]
    private List<BaseItem> droppedItems = new List<BaseItem>();
    
    public void ItemLoot()
    {
        Debug.Log(droppedItems);
        foreach (Loot item in loot)
        {
            if (Logic.RollDice(item.DropChance) == true)
            {
                Debug.Log(droppedItems);
                //item drop

                droppedItems.Add(item.MyItem);
                
            }
        }

    }
}
