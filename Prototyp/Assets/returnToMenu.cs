using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnToMenu : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            pause_start();
        }
    }
    public void loadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void restartLevel1()
    {
        SceneManager.LoadScene(1);
    }public void restartLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void resume()
    {
        panel.SetActive(false);
    }

    public void pause_start()
    {
        panel.SetActive(true);
    }
}
