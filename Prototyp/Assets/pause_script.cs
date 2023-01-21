using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_script : MonoBehaviour
{
    public GameObject trigger;
    [SerializeField]
    GameObject pause;
    [SerializeField]
    GameObject dialogue;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Pause");
            pause_menu();
        }
    }
    private void pause_menu()
    {
        pause.SetActive(true);
        Time.timeScale= 0f;
    }
    public void end_pause()
    {
        pause.SetActive(false);
        Time.timeScale= 1f;
    }

    public void restartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        end_pause();
        SceneManager.LoadScene(scene.name);
        
    }

    private void Start()
    {
        dialogue.SetActive(true);
        trigger.GetComponent<DialogueTrigger>().start_dialogue();
    }
}
