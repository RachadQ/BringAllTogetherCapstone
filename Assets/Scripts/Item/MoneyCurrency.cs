using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoneyCurrency : CurrBase
{
    Player player;
    public override void Interact()
    {
        base.Interact();
        player = FindObjectOfType<Player>();
        player.Money += Amount;
        player.inventory.UpdateGoldUi();
        Debug.Log(Amount);
        Destroy(this.gameObject);
    }

}
