using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeWall : MonoBehaviour
{
    public AIPath aIPath;

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Explosion")
        {
            gameObject.SetActive(false);
            aIPath.canMove = true;
        }
    }
}
