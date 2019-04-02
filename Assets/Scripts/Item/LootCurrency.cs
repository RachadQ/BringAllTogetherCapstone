using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class LootCurrency 
{

    [SerializeField]
    private int minAmount;
    public int MinAmount { get { return minAmount; } }

    [SerializeField]
    private int maxAmount;
    public int MaxAmount { get { return maxAmount; } }
    
    public int Currency { get { return Currency; }  }
    [SerializeField]
    private float dropChance;
    public float DropChance { get => dropChance; }
    // Start is called before the first frame update


}
