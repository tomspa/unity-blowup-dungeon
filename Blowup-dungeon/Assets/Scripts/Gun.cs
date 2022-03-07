using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Camera cam;
    public float maxRotation;

    Vector2 mousePos;

    private float loopAngle;

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rigidBody.position;
        float mouseAngle =  Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        loopAngle = Mathf.LerpAngle(loopAngle, mouseAngle, Time.deltaTime * 1.8f);

        rigidBody.transform.rotation = Quaternion.Euler(new Vector3(0, 0, loopAngle));
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        transform.localPosition = Vector2.zero;
    }
}
