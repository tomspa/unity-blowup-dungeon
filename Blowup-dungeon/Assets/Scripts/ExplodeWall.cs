using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeWall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Explosion")
        {
            gameObject.SetActive(false);
        }
    }
}
