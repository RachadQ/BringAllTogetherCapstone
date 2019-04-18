using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipable : BaseItem
{
    
    public ItemLocation EquipLocation { get { return Location; } set { Location = value; } }
    public int EquipItemLevelReq { get { return LevelReq; } set { LevelReq = value; } }
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public override void Interact()
    {
        base.Interact();


        player.inventory.AddItem(this);
        Destroy(this.gameObject);
        
    }

}
