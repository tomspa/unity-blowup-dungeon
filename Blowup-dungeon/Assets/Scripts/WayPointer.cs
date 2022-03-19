using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointer : MonoBehaviour
{
    Vector2 targetPosition;
    public Transform pointer;


    void Awake()
    {
        targetPosition = new Vector3(0f, 8.55f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toPosition = targetPosition;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.z = 0f;
        Vector3 direction = (toPosition - fromPosition).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;

        pointer.localEulerAngles = new Vector3 (angle, 0f, 0f);
    }
}
