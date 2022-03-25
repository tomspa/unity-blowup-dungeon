using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    [SerializeField]
    public AudioClip audioClip;
    public Camera cam;
    public Tank tank;

    public Vector3 explodePoint;

    public void Start() 
    {
        cam = FindObjectOfType<Camera>();
        tank = FindObjectOfType<Tank>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Explosion")
        {
            Explode();
        }
    }

    public void Update()
    {
        if (explodePoint != null && (cam.transform.position.x - tank.transform.position.x) < 2  && (cam.transform.position.y - tank.transform.position.y) < 2)
        {
            float exlodeDist = Vector2.Distance(explodePoint, cam.transform.position);
            float bulletDist = Vector2.Distance(transform.position, cam.transform.position);

            if (bulletDist >= exlodeDist)
            {
                Explode();
            }
        }
    }

    public void Explode()
    {
        AudioSource.PlayClipAtPoint(audioClip, transform.position);

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

        Destroy(effect, 0.5f);
        Destroy(gameObject);
    }

    public void SetExplodePoint(Vector3 vector)
    {
        explodePoint = vector;
    }
}
