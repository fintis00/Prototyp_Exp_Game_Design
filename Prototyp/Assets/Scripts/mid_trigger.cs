using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class mid_trigger : MonoBehaviour
{
    public GameObject trigger;
    public GameObject dialogue_window;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            dialogue_window.SetActive(true);
            trigger.GetComponent<DialogueTrigger>().start_dialogue();
            Destroy(gameObject);
        }
    }
}
