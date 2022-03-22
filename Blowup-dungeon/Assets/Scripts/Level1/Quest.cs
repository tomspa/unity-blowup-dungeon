using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool finished;
    public string title;
    public string description;
    public bool isActive;

    public QuestGoal goal;

    public List<ShootingTarget> targets;

    public void Setup()
    {
        foreach (ShootingTarget st in targets)
        {
            st.locked = false;
        }
    } 
    
    public void GotTarget()
    {
        Debug.Log("yes");
        goal.ItemDestroyed();
    }
}
