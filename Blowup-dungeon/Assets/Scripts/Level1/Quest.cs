using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public bool finished;
    public string title;
    public string description;
    public bool isActive;

    public void Start()
    {
    }
}
