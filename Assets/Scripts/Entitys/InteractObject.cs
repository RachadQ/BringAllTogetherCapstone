using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class InteractObject : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent Navplayer;
    private bool hasInteracted;


   

    //virtual so that it can be override to define  a type..NPC,Weapon
    public virtual void MoveToInteractable(NavMeshAgent _player)
    {
        hasInteracted = false;

        // what agent getting interacted with
        this.Navplayer = _player;
        Navplayer.stoppingDistance = 2f;
        _player.destination = this.transform.position;

     

    }

    protected void FixedUpdate()
    {
        //check if we have a player agent and path not pending
        if (!hasInteracted && Navplayer != null && !Navplayer.pathPending)
        {
            
            //distance from player to location and how far the stopping distance
            if (Navplayer.remainingDistance <= Navplayer.stoppingDistance)
            {
              
                Interact();
            
                hasInteracted = true;

            }

        }
    }

  
    public virtual void Interact()
    {
        Debug.Log("interact with base class");
    }



}
