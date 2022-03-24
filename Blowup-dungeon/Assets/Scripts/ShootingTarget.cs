using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTarget : MonoBehaviour
{
    public GameObject hitEffect;
    public bool locked = true;
    public Quest quest;
    private bool triggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!locked && (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Explosion") && !triggered)
        {
            triggered = true;
            if (hitEffect != null)
            {
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect, 5f);
            }

            quest.GotTarget();
            Destroy(gameObject);
        }
    }
}
