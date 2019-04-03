using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class KillGoal : Goal
{
   [SerializeField]
    public Monster enemy;
    public KillGoal(Monster _enemy ,string _description, bool _completed,int _amoutNeeded,int _requiredAmount)
    {
        enemy = _enemy;
        this.Description = _description;
        this.Completed = _completed;
        this.CurrentAmount = CurrentAmount;
        this.RequiredAmount = _requiredAmount;
      

    }

    public override void Init()
    {
        base.Init();
        EnemyDied(enemy);
    }

    void EnemyDied(Monster _enemy)
    {
        if (_enemy.UID == enemy.UID)
        {
            this.CurrentAmount++;
            Evalute();
        }
    }
   
}
