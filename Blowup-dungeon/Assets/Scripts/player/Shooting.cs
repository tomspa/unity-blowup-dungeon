using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    public static bool locked = false;
    public float bulletForce = 20f;

    float nextFire = 0.0f;
    public float fireDelay = 0.5f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !locked && Time.time > nextFire)
        {
            nextFire = Time.time + fireDelay;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootingPoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
