using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Resource,IRespawn
{
    public float time { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        currentAmount = MaxAmount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        currentAmount--;
        base.Interact();
    }

  

    public void Respawn(float Spawn)
    {

        if (!Alive)
        {

            time += Time.deltaTime * 1;


            if (time > Spawn)
            {
                //spawn is bug
                time = 0;
                currentAmount = MaxAmount;
                this.gameObject.GetComponent<MeshCollider>().enabled = true;
                this.gameObject.GetComponent<Renderer>().enabled = true;

                foreach (GameObject item in Child)
                {
                    item.SetActive(true);
                }
               // enemyui.UpdateUi();

            }


        }

    }
}
