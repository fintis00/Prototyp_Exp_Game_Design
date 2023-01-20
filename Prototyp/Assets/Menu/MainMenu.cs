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

    private void Start()
    {
        
        if (data.menu_first_visit == true)
        {
            Debug.Log("menufirst");
            data.level1BestTime = PlayerPrefs.GetFloat("level1BestTime");
            data.level2BestTime = PlayerPrefs.GetFloat("level2BestTime");
            data.level3BestTime = PlayerPrefs.GetFloat("level3BestTime");
            data.level4BestTime = PlayerPrefs.GetFloat("level4BestTime");
            data.level5BestTime = PlayerPrefs.GetFloat("level5BestTime");

            if (PlayerPrefs.GetInt("level2Unlocked") == 1) data.level2Unlocked = true; else data.level2Unlocked = false;
            if (PlayerPrefs.GetInt("level3Unlocked") == 1) data.level3Unlocked = true; else data.level3Unlocked = false;
            if (PlayerPrefs.GetInt("level4Unlocked") == 1) data.level4Unlocked = true; else data.level4Unlocked = false;
            if (PlayerPrefs.GetInt("level5Unlocked") == 1) data.level5Unlocked = true; else data.level5Unlocked = false;
  
        }
        data.menu_first_visit = false;
        PlayerPrefs.SetFloat("level1BestTime", data.level1BestTime);
        PlayerPrefs.SetFloat("level2BestTime", data.level2BestTime);
        PlayerPrefs.SetFloat("level3BestTime", data.level3BestTime);
        PlayerPrefs.SetFloat("level4BestTime", data.level4BestTime);
        PlayerPrefs.SetFloat("level5BestTime", data.level5BestTime);

        if (data.level2Unlocked == true) PlayerPrefs.SetInt("level2Unlocked", 1); else PlayerPrefs.SetInt("level2Unlocked", 0);
        if (data.level3Unlocked == true) PlayerPrefs.SetInt("level3Unlocked", 1); else PlayerPrefs.SetInt("level3Unlocked", 0);
        if (data.level4Unlocked == true) PlayerPrefs.SetInt("level4Unlocked", 1); else PlayerPrefs.SetInt("level4Unlocked", 0);
        if (data.level5Unlocked == true) PlayerPrefs.SetInt("level5Unlocked", 1); else PlayerPrefs.SetInt("level5Unlocked", 0);

    }
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
