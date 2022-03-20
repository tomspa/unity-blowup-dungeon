using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[System.Serializable]
public class Quest1 : Quest
{
    public string title;
    public string description;

    public bool isActive;

    public Quest1(Level1QuestSystem lvl1QuestSystem) : base(lvl1QuestSystem)
    {
    }

    public override void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Done()
    {
        finished = true;
        level1QuestSystem.NextQuest();
    }
}
