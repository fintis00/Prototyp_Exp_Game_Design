using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public DataScriptableObject data;
    public AudioClip menuDenied;
    public AudioClip menuAccept;
    public float volume;

    
    public void Level1()
    {
        AudioSource.PlayClipAtPoint(menuAccept, Camera.main.transform.position, volume);
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        if(data.level2Unlocked == true)
        {
            AudioSource.PlayClipAtPoint(menuAccept, Camera.main.transform.position, volume);
            SceneManager.LoadScene(2);
        }
        else
        {
            AudioSource.PlayClipAtPoint(menuDenied, Camera.main.transform.position, volume);
        }        
    }
    public void Level3()
    {
        if (data.level3Unlocked == true)
        {
            AudioSource.PlayClipAtPoint(menuAccept, Camera.main.transform.position, volume);
            SceneManager.LoadScene(3);
        }
        else
        {
            AudioSource.PlayClipAtPoint(menuDenied, Camera.main.transform.position, volume);
        }
    }
    public void Level4()
    {
        if (data.level4Unlocked == true)
        {
            AudioSource.PlayClipAtPoint(menuAccept, Camera.main.transform.position, volume);
            SceneManager.LoadScene(4);
        }
        else
        {
            AudioSource.PlayClipAtPoint(menuDenied, Camera.main.transform.position, volume);
        }
    }
    public void Level5()
    {
        if (data.level5Unlocked == true)
        {
            AudioSource.PlayClipAtPoint(menuAccept, Camera.main.transform.position, volume);
            SceneManager.LoadScene(5);
        }
        else
        {
            AudioSource.PlayClipAtPoint(menuDenied, Camera.main.transform.position, volume);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
