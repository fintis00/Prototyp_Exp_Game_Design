using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void start_dialogue()
    {
        TriggerDialogue();
    }

    public void TriggerDialogue()
    {
        Time.timeScale = 0.0f;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
