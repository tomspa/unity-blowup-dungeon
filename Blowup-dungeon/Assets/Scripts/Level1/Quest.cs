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

    public Text status;

    public void Setup()
    {
        progTextWindow.SetActive(true);
        //status = progTextWindow.GetComponent<Text>();
        //status.text = goal.requiredAmount + " of " + goal.currentAmount;
        
        foreach (ShootingTarget st in targets)
        {
            st.locked = false;
        }
    }
    
    public void GotTarget()
    {
        goal.ItemDestroyed();
        //status.text = goal.requiredAmount + " of " + goal.currentAmount;
        isFinished();
    }

    public bool isFinished()
    {
        if (goal.isReached())
        {

            return true;
        }

        return false;
    }
}
