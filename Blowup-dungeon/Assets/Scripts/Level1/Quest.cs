using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Quest
{
    protected bool finished;
    protected Level1QuestSystem level1QuestSystem;

    public bool isFinished()
    {
        return finished;
    }

    public Quest(Level1QuestSystem lvl1QuestSystem)
    {
        level1QuestSystem = lvl1QuestSystem;
        finished = false;
    }

    public abstract void Start();

}
