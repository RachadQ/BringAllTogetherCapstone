using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct CombatStats
{
    [SerializeField]
    public int MaxLife, MaxMana;
    [SerializeField]
    public int MinimumDamage, MaximumDamage, Defense;
    [SerializeField]
    public int MagicDamage, MagicResistance, MagicDefense;
    [SerializeField]
    public int AttackSpeed, AttackRange, Accuracy, Dodge;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
