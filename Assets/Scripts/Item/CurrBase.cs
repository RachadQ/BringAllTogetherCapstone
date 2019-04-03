using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrBase :InteractObject
{

    [SerializeField]
    private int amount;
    public int Amount { get { return amount; }  set { amount = value; } }
    [SerializeField]
    private CurrencyType type;
    public CurrencyType Type { get { return type; } }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
