using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField]
    Transform respawn1;
    [SerializeField]
    Transform respawn2;
    [SerializeField]
    Transform Player1;
    [SerializeField]
    Transform Player2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            
            Player1.position = respawn1.position;
            
        }
        if (other.CompareTag("Player2"))
        {

            Player2.position = respawn2.position;
        }
    }
}
