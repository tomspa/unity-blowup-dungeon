using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Level1QuestSystem : MonoBehaviour
{
    public GameObject waypoint;
    private WayPointer wayPointer;
    public GameObject target;
    public Vector3 questPoint1;
    public Vector3 questPoint2;
    public Vector3 questPoint3;

    public Quest quest1;

    // Start is called before the first frame update
    void Start()
    {
        questPoint1 = new Vector3(2.71f, 7.87f);
        questPoint2 = new Vector3(-36.32f, -0.38f);

        wayPointer = waypoint.GetComponent<WayPointer>();

        wayPointer.SetPoint(questPoint1);
        wayPointer.Hide();

        Invoke("startFirstQuest", 3f);
    }

    private void startFirstQuest()
    {
        wayPointer.Show();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextQuest()
    {
        wayPointer.SetPoint(questPoint2);
    }
}
