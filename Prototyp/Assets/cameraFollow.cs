using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 position;
    // Update is called once per frame
    void Update()
    {
        position.x = player.position.x;
        position.y = player.position.y+3f;
        position.z = player.position.z-10f;
        transform.position = position;
    }
}
