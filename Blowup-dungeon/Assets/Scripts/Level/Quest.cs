using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Quest : MonoBehaviour
{
    public bool finished;
    public string title;
    public string description;
    public bool isActive;
    public GameObject progTextWindow;
    public QuestGoal goal;
    public List<ShootingTarget> targets;
    public GameObject questFinishedWindow;

    public Text status;

    public void Setup()
    {
        progTextWindow.SetActive(true);
        status.text = goal.currentAmount + " of " + goal.requiredAmount;

        foreach (ShootingTarget st in targets)
        {
            st.locked = false;
        }
    }
    
    public void GotTarget()
    {
        goal.ItemDestroyed();
        status.text = goal.currentAmount + " of " + goal.requiredAmount;
        isFinished();
    }

    public void isFinished()
    {
        if (goal.isReached())
        {
            questFinishedWindow.SetActive(true);
        }
    }
}
