using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public SceneSwitch sceneSwitch;
    public GamePrefs gamePrefs;

    public void NewGame()
    {
        gamePrefs.SetGameLoadType(GameLoadType.New);
        sceneSwitch.DelayedSwitch();
    }
}
