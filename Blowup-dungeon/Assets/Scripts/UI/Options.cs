using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public Tank tank;
    public GamePrefs gamePrefs;
    public Toggle healthToggle;
    public Toggle speedyToggle;

    public void Start()
    {
        if (gamePrefs.GetSpeedy() > 0)
        {
            speedyToggle.isOn = true;
        }
        else {
            speedyToggle.isOn = false;
        }

        if (gamePrefs.GetInfinHealth() > 0) healthToggle.isOn = true;
        else healthToggle.isOn = false;
    }

    public void ClickResume()
    {
        Time.timeScale = 1f;
        transform.position = new Vector3(-1000, -1000, 1);
    }

    
    public void InfiniteHealth()
    {
        Debug.Log("healthhh");
        tank.infiniteHealth = !tank.infiniteHealth;
        if (tank.infiniteHealth) gamePrefs.SetInfinHealth(1);
        else gamePrefs.SetInfinHealth(0);

    }

    public void SpeedyGonzales()
    {
        Debug.Log("fasst");
        tank.movefast = !tank.movefast;
        if (tank.movefast) gamePrefs.SetSpeedy(1);
        else gamePrefs.SetSpeedy(0);
    }
}