using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest1 Quest;
    public Tank Tank;
    public GameObject QuestWindow;

    public Text text;
    public Text title;

    public void OpenQuestWindow()
    {
        QuestWindow.SetActive(true);
        title.text = Quest.title;
        text.text = Quest.description;
    }
}
