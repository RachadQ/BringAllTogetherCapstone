using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerMovement 
{

    [SerializeField]
    public Transform _destination;
    
   public NavMeshAgent navMeshAgent;
    public float JumpSpeed;
    public bool isJumping = false;
    
    // Start is called before the first frame update
   

   public PlayerMovement(GameObject player)
    {
        navMeshAgent = player.GetComponent<NavMeshAgent>();
        
        
    }
    // Update is called once per frame
    void Update()
    {
    }

   
    public void MovePlayer()
    {
        //create ray where u click
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //if player press left button 
        if (Input.GetMouseButtonDown(0))
        {



            //ignore other layers
            int layermask = 1 << navMeshAgent.gameObject.layer;
            
                if (Physics.Raycast(ray, out hit, 100, layermask))
                {
            
                GameObject _interactObject = hit.collider.gameObject;
                
                    bool interactable = _interactObject.tag == "item" || _interactObject.tag == "Npc" || _interactObject.tag == "artifact" || _interactObject.tag == "portal" || _interactObject.tag == "Enemy";

                    if (interactable)
                    {
                   
                        //what object that player interact with what type is derived from
                        _interactObject.GetComponent<InteractObject>().MoveToInteractable(navMeshAgent);
                     


                    }
                    else
                    {


                    //move agent to point where u click 0f;
                    navMeshAgent.stoppingDistance = 0f;
                   
                 
                        navMeshAgent.destination = hit.point;
                


                }

               
            }

            
        }

      
    }

    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            navMeshAgent.SetDestination(targetVector);
        }
    }
}
