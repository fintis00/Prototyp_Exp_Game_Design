using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    [SerializeField]
    string player_tag;

    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    AudioSource audioSource;

    public bool finished;
    
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        if (other.gameObject.CompareTag(player_tag))
        {
            Debug.Log(player_tag);
            Player.GetComponent<PlayerMovement>().enabled = false;
            panel.SetActive(true);
            finished = true;
        }
    }

    
}
