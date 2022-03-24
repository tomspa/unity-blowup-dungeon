using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public SceneSwitch sceneSwitch;
    public GamePrefs gamePrefs;

    public void Enter()
    {
        gamePrefs.SetGameLoadType(GameLoadType.Resume);
        sceneSwitch.Switch();
    }
}
