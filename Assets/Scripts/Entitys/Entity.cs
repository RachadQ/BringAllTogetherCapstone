using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Random = System.Random;

public class Entity : InteractObject,IGetChild
{
    public virtual uint UID { get; set; }
    public CombatStats combatStats;
    public virtual int AttackSpeed { get { return combatStats.AttackSpeed; } }
    public virtual int AttackRange { get { return Math.Max(2, combatStats.AttackRange); } }

    public virtual byte Xp { get; set; }
    public virtual string EntityName { get; set; }
    public virtual int Level { get; set; }
    public LootTable lootTable;
   
 
 
    public virtual int Mana { get; set; }
  

    public virtual int MaximumLife { get;  }
    public virtual int CurrentLife { get; set; }
    public bool Alive { get { return CurrentLife > 0; } }

    public virtual int MaximumMana { get { return combatStats.MaxMana; } }
    public virtual int MaximumStanima { get { return 100; } }
    public virtual int MaximumXp { get { return 100; } }
    public List<GameObject> Child { get; set; }

    internal bool sentDeath = false;

    public virtual int CalculateExpGain(Entity _target, int _dmg)
    {

        // if it is player dont get exp 
        if (_target is Player)
            return 0;
        //get exp depending if target is alive or dmg

        var exp = (double)Math.Min(_target.CurrentLife, _dmg);
        //get Level difference
        var levelDifference = Level - _target.Level;
        if (levelDifference >= 3)//Weak Monsters
        {
            if (levelDifference >= 3 && levelDifference <= 5)
                exp *= .7;
            else if (levelDifference > 5 && levelDifference <= 10)
                exp *= .2;
            else if (levelDifference > 10 && levelDifference <= 20)
                exp *= .1;
            else if (levelDifference > 20)
                exp *= .05;
        }

        else if (levelDifference < -15) // super stronger (black Name)
            exp *= 1.8;
        else if (levelDifference < -8) // strong (red name)
            exp *= 1.5;
        else if (levelDifference < -5) // close to level (white name)
            exp *= 1.3;

        return (int)exp;
    }


    public int CalculatePhysicalDamage(Entity _target, bool _canDodge = false)
    {
        System.Random rnd = new Random();
        var dmg = rnd.Next(combatStats.MinimumDamage, combatStats.MaximumDamage);
        if (_target is Monster)
        {
            //check if player is 3 levels higher then target
            dmg *= GetLevelBonus(Level, _target.Level);
        }

        dmg -= _target.combatStats.Defense;
        if (dmg < 1)
            dmg = 1;
        //if (_canDodge)
        //   dmg = 0;
        Debug.Log("player Damage: " + dmg + " attckers level: " + Level + " object attcked level: " + _target.Level);
        //   ulong exp = CalculateExperienceGain(_target, (uint)dmg);

        return (int)dmg;
    }

    

    public int GetLevelBonus(int l1, int l2)
    {
        int num = l1 - l2;
        int bonus = 1;
        if (num >= 3)
        {
            bonus = 2 + num / 3;
        }
        return bonus;
    }

    public virtual void RecieveDamage(int _dmg)
    {
        // if object is alive
        if (Alive)
        {
            int damage = Math.Min(CurrentLife, _dmg);
            // check if life is greater then damage delt
            if (damage == _dmg)
            {
                // do damage
                CurrentLife -= _dmg;
            }
            else
            {
                
                //sett player health to 0
                CurrentLife = 0;
                //check if it is a monster
                if (this is Monster)
                {
   
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
