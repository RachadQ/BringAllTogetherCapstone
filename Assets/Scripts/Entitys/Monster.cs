using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Entity
{
    Player target;

    public EnemyUi enemyui;
    public MonsterInfo monster;
    public LootTable MonsterLoot;
    public override int MaximumLife => combatStats.MaxLife + monster.Life;
    public override int CurrentLife { get => base.CurrentLife; set => base.CurrentLife = value; }

    
    public override int Level { get { return monster.Level; } }

    // Start is called before the first frame update
    void Start()
    {
       
        CurrentLife = MaximumLife;
        enemyui = new EnemyUi(this);
            
    }

   

    private void FixedUpdate()
    {
        base.FixedUpdate();
        NameColour();
     

    }
    // Update is called once per frame
    void Update()
    {
      
        
       
      
    }

   void EnemyDie()
    {

    }
    public void NameColour()
    {
        Player[] AllPlayers = GameObject.FindObjectsOfType<Player>();
        foreach (Player player in AllPlayers)
        {
            int levelDifference =  player.Level - this.Level;
            
            //if player 3 levels higher
            if (levelDifference >= 6)
            {

                
                //green name
                enemyui.name.color = Color.green;



            }
            if (levelDifference < 0 && levelDifference > -3)
            {
                
                //blackname
                enemyui.name.color = Color.red;
            }

            else if (levelDifference <= -4)
            {


                //blackname
                enemyui.name.color = Color.black;

            }
            else if(levelDifference < 4 && levelDifference <= 2)
            {
                
                //whiteName
                enemyui.name.color = Color.white;
            }
            

            
        }
    }
    public override void Interact()
    {
        base.Interact();
        target = FindObjectOfType<Player>();
        var dmg = target.CalculatePhysicalDamage(this);
        RecieveDamage(dmg);
      
        UpdateHealth(dmg);
        target.Experience += target.CalculateExpGain(this, dmg);
        Debug.Log(target.Experience);
    }

    public void UpdateHealth(int amount)
    {

        RecieveDamage(amount); 
        enemyui.UpdateUi();
        
    }


   
}
