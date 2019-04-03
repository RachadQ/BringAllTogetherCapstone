using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Goal
{   [SerializeField]
    private int requiredAmount;
    public int RequiredAmount { get { return requiredAmount; } set { requiredAmount = value; } }
    [SerializeField]
    private int currentAmount;
    public int CurrentAmount { get { return currentAmount; } set { currentAmount = value; } }
    [SerializeField]
    private bool completed;
    public bool Completed { get { return completed; } set { completed = value; } }
    [SerializeField]
    private string description;
    public string Description { get { return description; } set { description = value; } }

    public virtual void Init()
    {

    }


    public void Evalute()
    {
        if (CurrentAmount >= RequiredAmount)
        {
            Complete();
        }
    }

    public void Complete()
    {
        completed = true;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
