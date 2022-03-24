using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointer : MonoBehaviour
{
    public Transform pointer;
    private Vector3 nextPoint;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        Vector3 toPosition = nextPoint;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.z = 0f;
        Vector3 direction = (toPosition - fromPosition).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if (angle < 0) angle += 360;

        pointer.localEulerAngles = new Vector3 (0f, 0f, angle);
    }

    public void SetPoint(Vector3 point)
    {
        nextPoint = point;
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
        target.gameObject.SetActive(false);
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
        target.gameObject.SetActive(true);
    }
}
