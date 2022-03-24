using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public int sceneNumber;
    public GamePrefs gamePrefs;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Switch();
    }

    public void Switch()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneNumber);
    }

    public void DelayedSwitch()
    {
        Invoke("Switch", 1f);
    }
}
