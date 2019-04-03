using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class QuestSystem 
{
    [SerializeField]
    public List<Quest> quests;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddQuest(Quest _quest) { quests.Add(_quest); }
}
