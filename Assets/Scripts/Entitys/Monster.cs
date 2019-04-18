using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
public class Monster : Entity,IRespawn
{
    Player target;
   
    public EnemyUi enemyui;
    public MonsterInfo monster;
    public float SpawnRate;
    public override int MaximumLife => combatStats.MaxLife + monster.Life;
    public override int CurrentLife { get => base.CurrentLife; set => base.CurrentLife = value; }

    
    public override int Level { get { return monster.Level; } }

    public float time { get; set; }

    // Start is called before the first frame update
    private void Start()
    {
    
        Child = new List<GameObject>();
        GetChildren();
        
        CurrentLife = MaximumLife;
        enemyui = new EnemyUi(this);
        enemyui.name.text = monster.Name;
       
    }



    private new void FixedUpdate()
    {
      
        base.FixedUpdate();
        NameColour();
     


    }

    
    private void LateUpdate()
    {
       
    }
    // Update is called once per frame
    new void Update()
    {
        Respawn(SpawnRate);
      

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
            if (levelDifference > 2)
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
            else if(levelDifference < 3 && levelDifference >= 0)
            {
                
                //whiteName
                enemyui.name.color = Color.gray;
            }
            

            
        }
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
                CurrentLife = MaximumLife;
                this.gameObject.GetComponent<MeshCollider>().enabled = true;
                this.gameObject.GetComponent<Renderer>().enabled = true;

                foreach (GameObject item in Child)
                {
                    item.SetActive(true);
                }
                enemyui.UpdateUi();

            }


        }

    }

public override void Interact()
    {
        base.Interact();
        target = FindObjectOfType<Player>();
        var dmg = target.CalculatePhysicalDamage(this);
       // RecieveDamage(dmg);
      
        UpdateHealth(dmg);
        var exp  = target.CalculateExpGain(this, dmg);
        FloatingTextController.CreateFloatingText(dmg.ToString(), this.transform);
        target.GainExperience(exp);
       
        //Debug.Log(target.Experience);
    }

    public void UpdateHealth(int amount)
    {

        RecieveDamage(amount); 
        enemyui.UpdateUi();
      
        
    }
}
