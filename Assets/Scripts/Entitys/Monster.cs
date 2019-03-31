using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Entity
{
    Player Target;

    public EnemyUi enemyui;
    public MonsterInfo monster;
    
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
        NameColour();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Damage(5);
           
            
          
            
        }
        
       
      
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
                //blackname
                enemyui.name.color = Color.black;


            }
            if (levelDifference >= 3 && levelDifference < 6)
            {
                //blackname
                enemyui.name.color = Color.red;
            }

            else if (levelDifference < 0)
            {
              

                //green name
                enemyui.name.color = Color.green;
            }
            else if(levelDifference < 4 && levelDifference <= 2)
            {
                //whiteName
                enemyui.name.color = Color.white;
            }
            

            
        }
    }

    public void Damage(int amount)
    {
       
        CurrentLife -= amount;
        if (CurrentLife <= 0)
        {
            CurrentLife = 0;
        }
        enemyui.UpdateUi();
        
    }


    public override void Interact()
    {
        base.Interact();

    }
}
