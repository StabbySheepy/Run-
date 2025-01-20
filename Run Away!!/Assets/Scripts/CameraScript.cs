using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
public Transform player;
Vector3 velocity = Vector3.zero;
public float smoothTime = .15f;
//private Vector3 offset;
//player.position.x + offset.x, player.position.y + offset.y, offset.z

// Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 10);

    }
}
