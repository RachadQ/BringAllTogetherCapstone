using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pp : InteractObject
{
   public Player player;
    public GameObject teleportSpot;
    
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public override void Interact()
    {
        base.Interact();
        player.teleport(teleportSpot);
    }
    public override void MoveToInteractable(NavMeshAgent _player)
    {
        base.MoveToInteractable(_player);
        _player.stoppingDistance = 0f;
        //  _player.destination = this.transform.position;
    }
}
