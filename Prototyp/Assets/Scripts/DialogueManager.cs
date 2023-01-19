using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject Dialogue_window;
    public TMP_Text dialogue_text;
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        sentences.Clear();

        foreach(string sentence in dialogue.list_of_sentences)
        {
            sentences.Enqueue(sentence);
        }

        displayNextSentence();
    }

    public void displayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogue_text.text = sentence;
    }   

    public void EndDialogue()
    {
        Dialogue_window.SetActive(false);
        Time.timeScale= 1.0f;
    }

    
}
