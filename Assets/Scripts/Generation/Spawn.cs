using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Spawn 
{
    [SerializeField]
    private GameObject spawnMonster;
    public GameObject SpawnMonsters
    {
        get { return spawnMonster; }
        set { spawnMonster = value; }
    }


  
    private Vector3[] entityPosition;
    public Vector3[] EntityPosition
    {
        get { return entityPosition; }
        set { entityPosition = value; }
    }


    private int currentAmount;
    public int CurrentAmount
    {
        get { return currentAmount; }
        set { currentAmount = spawnAmount; }
    }
    [SerializeField]
    private int spawnAmount;
    public int SpawnAmount
    {
        get { return spawnAmount; }
        //set { spawnAmount = value; }
    }

    public void setAmountPositions(int amount)
    {
        entityPosition = new Vector3[amount];
    }
}
