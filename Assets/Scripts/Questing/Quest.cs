using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[System.Serializable]
public class Quest 
{
    [SerializeField]
    private List<Goal> goal;
    public List<Goal> Goals { get { return goal; } set { goal = value; } }
    [SerializeField]
    private string questName;
    public string QuestName { get { return questName; } set { questName = value; } }
    [SerializeField]
    private string description;
    public string Description { get { return description; } set { description = value; } }
    [SerializeField]
    private int experienceReward;
    public int ExperienceReward { get { return experienceReward; } set { experienceReward = value; } }
    [SerializeField]
    private LootTable loot;
    public LootTable Loot { get { return loot; } set { loot = value; } }
    [SerializeField]
    private bool complete;
    public bool Completed { get { return complete; } set { complete = value; } }

    public void CheckGoals()
    {

        Completed = Goals.All(g => g.Completed);
        if (Completed)
        GiveReward();
        
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);

    }

    void GiveReward()
    {
        if (Loot != null)
        {
            ///add item to inventory
        }
    }

}
