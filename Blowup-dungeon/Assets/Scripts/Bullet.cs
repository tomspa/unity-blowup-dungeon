using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    [SerializeField]
    public AudioClip audioClip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

        Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
