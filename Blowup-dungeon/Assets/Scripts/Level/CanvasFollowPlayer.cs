using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollowPlayer : MonoBehaviour
{
    public Transform player;

    private void FixedUpdate()
    {
        this.GetComponent<RectTransform>().position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
