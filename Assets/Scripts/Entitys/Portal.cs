using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Portal : InteractObject
{
    private Player player;
    public GameObject teleportSpot;
    // Start is called before the first frame update
    void Start()
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
    }
}
