using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;
    public Tank tank;
    public GameObject questWindow;

    public Text text;
    public Text title;

    public GameObject indicator;
    public GameObject arrow;
    
    public void OpenQuestWindow()
    {
        if (questWindow.activeInHierarchy == false && !quest.isActive)
        {
            Time.timeScale = 0.0f;
            questWindow.SetActive(true);
            Shooting.locked = true;
            title.text = quest.title;
            text.text = quest.description;
        }
    }

    public void AcceptQuest()
    {
        Time.timeScale = 1f;
        questWindow.SetActive(false);
        quest.isActive = true;
        Shooting.locked = false;
        tank.quest = quest;
        indicator.SetActive(false);
        arrow.SetActive(false);
        quest.Setup();
    }
}
