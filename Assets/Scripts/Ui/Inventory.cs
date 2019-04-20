using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[System.Serializable]
public class Inventory 
{
    Player owner;
    public BaseItem[] items = new BaseItem[40];
    // Start is called before the first frame update
    public InventorySlot[] inventorySlots;
    public InventoryCash inventoryCash;
    public SlotDescription itemDescription;

    public Inventory(Player _owner)
    {
        owner = _owner;
      inventorySlots = GameObject.FindObjectsOfType<InventorySlot>();
        itemDescription = new SlotDescription();
        inventoryCash = new InventoryCash(owner);
    }

    public bool Add(BaseItem item)
    {
        for (int i = 0; i < items.Length; i++)
        {

            //if item slot is empty
            if (items[i] == null)
            {
                //set this item slot to this item
                items[i] = item;
                //set the ui
                inventorySlots[i].item = item;
                //Set the buttons
              //  UpdateButtonUi( itemDescription, inventorySlots[i]);
              
                //so it don't full all slots
              
               
                return true;
            }
        }
        return false; 
    }

    public void RemoveItem(BaseItem item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                items[i] = null;
                inventorySlots[i].item = null;
                inventorySlots[i].icon.sprite = null;
                inventorySlots[i].icon.enabled = false;
                return;

                //inventorySlots[i].item = item;
             //   UpdateSlotUi();
            }
        }

    }

   
    public void UpdateSlotUi()
    {
        // go through inventory slots
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (items[i] != null)
            {
                inventorySlots[i].UpdateSlot();
            }

        }
    }
    public void UpdateGoldUi()
    {
        inventoryCash.goldText.text = owner.Money.ToString();

    }
    public void AddItem(BaseItem item)
    {

        bool hasAdded = Add(item);
        if (hasAdded)
        {
            UpdateSlotUi();
        }
    }

    public void UpdateButtonUi(SlotDescription panel, InventorySlot slot)
    {    
        //check if its equipable type
        if (slot.item is Equipable)
        {
            slot.PopulateButtons(panel.ButtonsPanel, slot.itemButtons[1]);
            
            if (slot.item.CurrentDuration != slot.item.MaxDuration)
            {
                slot.PopulateButtons(panel.ButtonsPanel, slot.itemButtons[2]);
             //   MonoBehaviour.Instantiate()
            }
        }

        if (slot.item is Consumables)
        {
            slot.PopulateButtons(panel.ButtonsPanel, slot.itemButtons[1]);
        }


       
    }


}
