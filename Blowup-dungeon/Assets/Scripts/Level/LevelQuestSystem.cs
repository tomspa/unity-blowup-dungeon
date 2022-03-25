using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class LevelQuestSystem : MonoBehaviour
{
    public GameObject waypoint;
    public GameObject pointer;
    private WayPointer wayPointer;
    public GameObject target;
    public Vector3 questPoint1;
    public Vector3 questPoint2;
    public Vector3 questPoint3;
    public GameObject questFinishedWindow;
    public GameObject questProgressWindow;
    public bool startWithDelay;
    public GameObject onlyTargetCircle;

    private int currentQuest = 0;
    private Vector3[] quests = new Vector3[4];

    // Start is called before the first frame update
    void Start()
    {
        quests[0] = questPoint1;
        quests[1] = questPoint2;

        wayPointer = waypoint.GetComponent<WayPointer>();

        currentQuest = 0;
        wayPointer.SetPoint(quests[0]);
        wayPointer.Hide();

        if (!startWithDelay)
        {
            startFirstQuest();
        } else
        {
            Invoke("startFirstQuest", 3f);
        }
    }

    private void startFirstQuest()
    {
        wayPointer.Show();
    }

    public void NextQuest()
    {
        currentQuest++;
        wayPointer.SetPoint(quests[currentQuest]);
        questFinishedWindow.SetActive(false);
        questProgressWindow.SetActive(false);
        if (pointer != null) pointer.SetActive(true);
        wayPointer.Show();
        if (onlyTargetCircle != null) onlyTargetCircle.SetActive(false); 
    }
}
