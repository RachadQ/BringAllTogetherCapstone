using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : InteractObject,IGetChild
{
    public int MaxAmount { get; set; }
    public int currentAmount { get; set; }
    public int resource = 1;
    public bool Alive { get { return currentAmount > 0; } }
    public List<GameObject> Child { get; set; }
    public LootTable lootTable;



    public virtual void RecieveResource(int amount)
    {
        // if object is alive
        if (Alive)
        {
            int damage = resource;
            // check if life is greater then damage delt
            if (damage == amount)
            {
                // do damage
                currentAmount -= amount;
            }
            else
            {

                //sett player health to 0
                currentAmount = 0;
                //check if it is a monster
               

                    lootTable.DropLoot(this.gameObject);
                    this.gameObject.GetComponent<MeshCollider>().enabled = false;
                    this.gameObject.GetComponent<Renderer>().enabled = false;
                    foreach (GameObject item in Child)
                    {

                        item.SetActive(false);
                    }

                
            }
       }
    }
        //public LootTable lootTable;
        // Start is called before the first frame update
        void Start()
         {
        
         }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetChildren()
    {

        foreach (Transform child in transform)
        {
            //Add child to childObjects;
            Child.Add(child.gameObject);


        }

    }
}
