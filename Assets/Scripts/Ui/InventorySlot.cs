using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    public BaseItem item;
    public Image  icon;
    public Button[] itemButtons = new Button[4];
    public List<Button> InitButton;
    public void UpdateSlot()
    {
        if (item != null)
        {
           
            icon.GetComponent<Image>().sprite = item.Sprite;
          
        }
        else
        {
          
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        icon = this.gameObject.GetComponent<Image>();
        //depositButton
        itemButtons[0] = Resources.Load<Button>("ItemInfoButton/ItemDepositButton") ;
        //EquipButton
        itemButtons[1] = Resources.Load<Button>("ItemInfoButton/ItemEquipButton");
        //repair button
        itemButtons[2] = Resources.Load<Button>("ItemInfoButton/ItemRepairButton");
        //UseButton
        itemButtons[3] = Resources.Load<Button>("ItemInfoButton/ItemUseButton");
      
    }

     public void PopulateButtons(GameObject buttonPanel, Button _button)
    {
        InitButton.Add(_button);
  
      
       
     
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
