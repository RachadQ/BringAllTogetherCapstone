using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

<<<<<<< HEAD
public class Monster :Entity
{
    Player Target;
=======
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

>>>>>>> 8fa4f9b65f9394ce1bf557b3386017816001b548
    // Start is called before the first frame update
    private void Start()
    {
<<<<<<< HEAD
        
    }

=======
        Child = new List<GameObject>();
        GetChildren();
        
        CurrentLife = MaximumLife;
        enemyui = new EnemyUi(this);
      
    }

   

    private new void FixedUpdate()
    {
      
        base.FixedUpdate();
        NameColour();
     


    }

    private void LateUpdate()
    {
       
    }
>>>>>>> 8fa4f9b65f9394ce1bf557b3386017816001b548
    // Update is called once per frame
    new void Update()
    {
<<<<<<< HEAD
        
    }
    public override void Interact()
=======
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
            else if(levelDifference < 3 && levelDifference > 0)
            {
                
                //whiteName
                enemyui.name.color = Color.white;
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
>>>>>>> 8fa4f9b65f9394ce1bf557b3386017816001b548
    {
        base.Interact();
        target = FindObjectOfType<Player>();
        var dmg = target.CalculatePhysicalDamage(this);
       // RecieveDamage(dmg);
      
        UpdateHealth(dmg);
        var exp  = target.CalculateExpGain(this, dmg);
        target.GainExperience(exp);
       
        //Debug.Log(target.Experience);
    }

    public void UpdateHealth(int amount)
    {

        RecieveDamage(amount); 
        enemyui.UpdateUi();
      
        
    }
}
