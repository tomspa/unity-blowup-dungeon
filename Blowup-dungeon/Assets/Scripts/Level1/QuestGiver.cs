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

    public void OpenQuestWindow()
    {
        if (questWindow.activeInHierarchy == false && !quest.isActive)
        {
            questWindow.SetActive(true);
            Shooting.locked = true;
            title.text = quest.title;
            text.text = quest.description;
        }
    }

    public void AcceptQuest()
    {
        questWindow.SetActive(false);
        quest.isActive = true;
        Shooting.locked = false;
        tank.quest = quest;
        indicator.SetActive(false);
        quest.Setup();
    }
}
