using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
[System.Serializable]
public class LootTable 
{
    [SerializeField]
    public Loot[] loot;
    [SerializeField]
    public List<BaseItem> droppedItems = new List<BaseItem>();
    [SerializeField]
    private LootCurrency Currency;
    [SerializeField]
    public CurrBase droppedcurrency;

    public void DropLoot(GameObject entity)
    {
        if (entity.GetComponent<Player>())
        {
            return;
        }
       // Debug.Log(Currency.DropChance);
        //Debug.Log(Logic.RollDice(Currency.DropChance));
        //populate loot
        ItemLoot();
        CurrencyLoot();
        
        //spawn loot
        SpawnObjects(entity.transform, droppedItems, droppedcurrency);

       

    }

    public void SpawnObjects(Transform SpawnPoint, List<BaseItem> droppedItems, CurrBase droppedCurrency)
    {
      
        foreach (BaseItem obj in droppedItems)
        {
            if (droppedItems != null)
            {



                GameObject item = GameObject.Instantiate(obj.gameObject, Logic.GivenArea(SpawnPoint.position, new Vector3(2, 1, 2)), SpawnPoint.rotation) as GameObject;
            }
           
        }
        if (droppedcurrency != null)
        {
            GameObject currency = GameObject.Instantiate(droppedCurrency.gameObject, Logic.GivenArea(SpawnPoint.position, new Vector3(2, 1, 2)), SpawnPoint.rotation) as GameObject;
        }
       
       
    }

    public void CurrencyLoot()
    {
        if (droppedcurrency == null)
        {

        }
        if (Logic.RollDice(Currency.DropChance) == true)
        {
            
            // get random between max and min
            System.Random rnd = new Random();
            droppedcurrency.Amount = rnd.Next(Currency.MinAmount, Currency.MaxAmount);
          //  Debug.Log("droppeAmount"+ droppedcurrency.Amount);
            
        }
    }
    public void ItemLoot()
    {

        if (loot == null)
        {
            return;
        }
        foreach (Loot item in loot)
        {
            

            if (Logic.RollDice(item.DropChance) == true)
            {

              
                droppedItems.Add(item.MyItem);
                
            }
        }

    }



    
}
