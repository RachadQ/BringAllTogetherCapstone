using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem : InteractObject
{
    public Player player;

    [SerializeField]
    private Sprite sprite;
    public Sprite Sprite { get { return sprite; } set { sprite = value; } }

    [SerializeField]
    private string itemName;
    public virtual string ItemName { get { return itemName; } set { itemName = value; } }

    

    [SerializeField]
    private ItemLocation location;
    public virtual ItemLocation Location { get { return location; } set { location = value; } }

    [SerializeField]
    private uint uniqueID;
    public virtual uint UniqueID { get { return uniqueID; } set { uniqueID = value; } }

    /// <summary>
    /// equip item overides
    /// </summary>
    ///
    [SerializeField]
    private int levelReq;
    public virtual int LevelReq { get { return levelReq; } set { levelReq = value; } }

    [SerializeField]
    private WeaponType weapon;
    public virtual WeaponType WeaponT { get { return weapon; } set { weapon = value; } }

    [SerializeField]
    private int attackRange;
    public virtual int AttackRange { get { return attackRange; } set { attackRange = value; } }

    [SerializeField]
    private int attackSpeed;
    public virtual int AttackSpeed { get { return attackSpeed; } set { attackSpeed = value; } }

    [SerializeField]
    private int attackMin;
    public virtual int AttackMin { get { return attackMin; } set { attackMin = value; } }

    [SerializeField]
    private int attackMax;
    public virtual int AttackMax { get { return attackMax; } set { attackMax = value; } }

    [SerializeField]
    private int defenceAdd;
    public virtual int DefenceAdd { get { return defenceAdd; } set { defenceAdd = value; } }

    [SerializeField]
    private int accuracyAdd;
    public virtual int AccuracyAdd { get { return accuracyAdd; } set { accuracyAdd = value; } }

    [SerializeField]
    private int dodgeAdd;
    public virtual int DodgeAdd { get { return dodgeAdd; } set { dodgeAdd = value; } }

    [SerializeField]
    private int magicAttack;
    public virtual int MagicAttack { get { return magicAttack; } set { magicAttack = value; } }

    [SerializeField]
    private int magicDefence;
    public virtual int MagicDefence { get { return magicDefence; } set { magicDefence = value; } }

    [SerializeField]
    private ushort healthAdd;
    public virtual ushort HealthAdded { get { return healthAdd; } set { healthAdd = value; } }

    [SerializeField]
    private ushort manaAdd;
    public virtual ushort ManaAdded { get { return manaAdd; } set { manaAdd = value; } }


    [SerializeField]
    private ushort maxDuration;
    public virtual ushort MaxDuration { get { return maxDuration; } set { maxDuration = value; } }

    [SerializeField]
    private ushort currentDuration;
    public virtual ushort CurrentDuration { get { return currentDuration; } set { currentDuration = value; } }
    //

    //equipable base Item'
   // public BaseItem()


}
