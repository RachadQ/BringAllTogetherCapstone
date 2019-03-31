using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PC 
{
    [SerializeField]
    private int uID;
    public virtual int UID { get { return uID; } set { uID = value; } }
    [SerializeField]
    public  string name;
    public virtual string Name { get { return name; } set { name = value; } }
    public virtual string Spouse { get; set; }
    [SerializeField]
    private int level;
    public virtual int Level { get {return level; } set { level = value; } }
    public virtual int Money { get; set; }
    public virtual int BankMoney { get; set; }
    public virtual int Gem { get; set; }
    [SerializeField]
    private int experience;
    public virtual int Experience { get { return experience; } set { experience = value; } }
    [SerializeField]
    private int strengh;
    public virtual int Strength { get {return strengh; } set { strengh = value; } }
    [SerializeField]
    private int agility;
    public virtual int Agility { get {return agility; } set { agility = value; } }
    [SerializeField]
    private int intellect;
    public virtual int Intellect { get { return intellect; } set { intellect = value; } }
    [SerializeField]
    private int vitality;
    public virtual int Vitality { get { return vitality; } set { vitality = value; } }
    public virtual int ExtraStats { get; set; }
    [SerializeField]
    private int life;
    public virtual int Life { get { return life; } set { life = value; } }
    [SerializeField]
    private int mana;
    public virtual int Mana { get { return mana; } set { mana = value; } }

    [SerializeField]
    private int pk;
    public virtual int Pk { get { return pk; } set { pk = value; } }
   


    public bool Online { get; set; }

}
