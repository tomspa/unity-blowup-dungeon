using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAudio : MonoBehaviour
{
    private GameObject[] MusicObjects;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        MusicObjects = GameObject.FindGameObjectsWithTag("Music");

        if (MusicObjects.Length > 1)
        {
            Destroy(MusicObjects[1]);
        }
    }
}
