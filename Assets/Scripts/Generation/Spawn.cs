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

    private Transform[] entityPosition;
    public Transform[] EntityPosition
    {
        get { return entityPosition; }
        set { entityPosition = value; }
    }

    [SerializeField]
    private int spawnAmount;
    public int SpawnAmount
    {
        get { return spawnAmount; }
        //set { spawnAmount = value; }
    }


    public void SetAmount(int amount)
    {
        EntityPosition = new Transform[amount];
    }


}
