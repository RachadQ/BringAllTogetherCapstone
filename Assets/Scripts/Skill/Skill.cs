using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill 
{
    [SerializeField]
    private string skillName;
    public string Name { get {return skillName; } set { skillName = value; } }


    [SerializeField]
    private string description;
    public string Description { get { return description; } set { description = value; } }


    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } set { damage = value; } }

    [SerializeField]
    private int cost;
    public int Cost { get { return cost; } set { cost = value; } }

    public virtual void Cast()
    {
       
    }


}
