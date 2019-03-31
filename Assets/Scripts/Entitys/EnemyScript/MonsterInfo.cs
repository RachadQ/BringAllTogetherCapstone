using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public struct MonsterInfo 
{

    [SerializeField]
    private int id;
    public int ID { get { return id; } set { id = value; } }
    [SerializeField]
    private string name;
    public string Name { get { return name; } set { name = value; } }

    [SerializeField]
    private int life;
    public int Life { get { return life; } set { life = value; } }

    [SerializeField]
    private int attackMax;
    public int AttackMax { get { return attackMax; } set { attackMax = value; } }

    [SerializeField]
    private int attackMin;
    public int AttackMin { get { return attackMin; } set { attackMin = value; } }

    [SerializeField]
    private int attackRange;
    public int AttackRange { get { return attackRange; } set { attackRange = value; } }

    [SerializeField]
    private int accuracy;
    public int Accuracy { get; set; }

    [SerializeField]
    private int defence;
    public int Defence { get { return defence; } set { defence = value; } }

    [SerializeField]
    private int magicDefence;
    public int MagicDefence { get { return magicDefence; } set { magicDefence = value; } }
    [SerializeField]
    private int moveSpeed;
    public int MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }
    [SerializeField]
    private int level;
    public int Level { get { return level; } set { level = value; } }
    [SerializeField]
    private int dodge;
    public int Dodge { get { return dodge; } set { dodge = value; } }

}
