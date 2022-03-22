using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTarget : MonoBehaviour
{
    public GameObject hitEffect;
    public bool locked = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!locked && (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Explosion"))
        {
            if (hitEffect != null)
            {
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect, 5f);
            }

            gameObject.SendMessageUpwards("GotTarget", SendMessageOptions.RequireReceiver);
            Destroy(gameObject);
        }
    }
}
