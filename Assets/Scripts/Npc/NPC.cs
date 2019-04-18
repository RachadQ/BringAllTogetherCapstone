using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : InteractObject
{
    public string[] dialogue;
    public string npcName;
    public Player client;
   
    public override void Interact()
    {
        base.Interact();

        client = FindObjectOfType<Player>();
        DialogueSystem.instance.AddNewDialogue(dialogue, npcName);
    }

    private void Start()
    {

      
    }


}
