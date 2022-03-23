using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public Tank tank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickResume()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void InfiniteHealth()
    {
        tank.infiniteHealth = !tank.infiniteHealth;
    }

    public void SpeedyGonzales()
    {
        tank.movefast = !tank.movefast; 
    }
}