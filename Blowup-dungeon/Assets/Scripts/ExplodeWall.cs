using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeWall : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Sa=tart");
    }

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Explosion")
        {
            gameObject.SetActive(false);
        }
    }
}
