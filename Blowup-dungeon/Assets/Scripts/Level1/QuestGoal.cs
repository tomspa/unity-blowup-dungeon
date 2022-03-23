using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;
    public GameObject progTextWindow;

    public bool isReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void ItemDestroyed()
    {
        if (goalType == GoalType.Destroy)
        {
            currentAmount++;
        }
    }
}

public enum GoalType
{
    Destroy,
    Find
}
