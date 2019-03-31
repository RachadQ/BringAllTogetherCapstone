using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Loot 
{
    [SerializeField]
    private BaseItem items;
    [SerializeField]
    private float dropChance;

    public BaseItem MyItem { get => items;  }
    public float DropChance { get => dropChance;  }
}
