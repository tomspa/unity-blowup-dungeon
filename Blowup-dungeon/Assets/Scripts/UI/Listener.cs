using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    public GameObject optionsWindow;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Time.timeScale = 0f;    
            optionsWindow.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, 1);
        }
    }
}
