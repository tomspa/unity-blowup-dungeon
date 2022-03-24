using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrefs : MonoBehaviour
{
    public void SetPlayerHealth(int health)
    {
        PlayerPrefs.SetInt("Health", health);
    }

    public int GetPlayerHealth()
    {
        return PlayerPrefs.GetInt("Health");
    }

    public void SetGameLoadType(GameLoadType loadType)
    {
        PlayerPrefs.SetString("GameLoadType", loadType.ToString());
    }

    public GameLoadType GetGameLoadType()
    {
        return GameLoadTypeHelper.GetGameLoadType(PlayerPrefs.GetString("GameLoadType"));
    }

    public void SetScene(int scene)
    {
        PlayerPrefs.SetInt("Scene", scene);
    }

    public int GetScene()
    {
        return PlayerPrefs.GetInt("Scene");
    }
}

public enum GameLoadType
{
    New,
    Resume
}

public static class GameLoadTypeHelper 
{
    public static GameLoadType GetGameLoadType(string loadType)
    {
        if (loadType.Equals("Resume")) return GameLoadType.Resume;
        else if (loadType.Equals("New")) return GameLoadType.New;
        else return GameLoadType.New;
    }
}
