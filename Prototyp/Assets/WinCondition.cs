using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using System;

public class WinCondition : MonoBehaviour
{
    bool player1_complete;
    bool player2_complete;
    public int levelNumber;

    [SerializeField]
    GameObject panel_left;
    [SerializeField]
    GameObject panel_right;
    [SerializeField]
    GameObject endscreen;

    [SerializeField]
    GameObject looseScreen;

    [SerializeField]
    GameObject finish1;
    [SerializeField]
    GameObject finish2;

    [SerializeField]
    GameObject Timer;

    [SerializeField]
    GameObject panel;
    [SerializeField]
    DataScriptableObject data;

    // Update is called once per frame
    void Update()
    {
        
        checkFinish();
        if(player1_complete && player2_complete) {
            panel_left.SetActive(false);
            panel_right.SetActive(false);
            Timer.GetComponent<TimeController>().EndTimer();
                       
            if (Timer.GetComponent<TimeController>().timeLeftSeconds > 0)
            {
                showEndscreen();
            }
        }
        checkTime();
    }

    private void checkFinish() {
        player1_complete = finish1.GetComponent<finish>().finished;
        player2_complete= finish2.GetComponent<finish>().finished;
    }

    private void showEndscreen()
    {
        switch (levelNumber)
        {
            case 1:
                data.level2Unlocked = true;
                if (data.level1BestTime < Timer.GetComponent<TimeController>().timeLeftSeconds)
                {                   
                    data.level1BestTime = Timer.GetComponent<TimeController>().timeLeftSeconds;
                    TextMeshProUGUI text = endscreen.GetComponentInChildren<TextMeshProUGUI>();

                    text.text += "\nNew Best Time: " + TimeSpan.FromSeconds(data.level1BestTime).ToString("ss'.'ff");
                }               
                break;
            case 2:
                data.level3Unlocked = true;
                if (data.level2BestTime < Timer.GetComponent<TimeController>().timeLeftSeconds)
                {                   
                    data.level2BestTime = Timer.GetComponent<TimeController>().timeLeftSeconds;
                    TextMeshProUGUI text = endscreen.GetComponentInChildren<TextMeshProUGUI>();
                    text.text += "\nNew Best Time: " + TimeSpan.FromSeconds(data.level2BestTime).ToString("ss'.'ff");
                }
                break;
            case 3:
                data.level4Unlocked = true;
                if (data.level3BestTime < Timer.GetComponent<TimeController>().timeLeftSeconds)
                {                  
                    data.level3BestTime = Timer.GetComponent<TimeController>().timeLeftSeconds;
                    TextMeshProUGUI text = endscreen.GetComponentInChildren<TextMeshProUGUI>();
                    text.text += "\nNew Best Time: " + TimeSpan.FromSeconds(data.level3BestTime).ToString("ss'.'ff");
                }
                break;
            case 4:
                data.level5Unlocked = true;
                if (data.level4BestTime < Timer.GetComponent<TimeController>().timeLeftSeconds)
                {                 
                    data.level4BestTime = Timer.GetComponent<TimeController>().timeLeftSeconds;
                    TextMeshProUGUI text = endscreen.GetComponentInChildren<TextMeshProUGUI>();
                    text.text += "\nNew Best Time: " + TimeSpan.FromSeconds(data.level4BestTime).ToString("ss'.'ff");
                }
                break;
            case 5:               
                if (data.level5BestTime < Timer.GetComponent<TimeController>().timeLeftSeconds)
                {                 
                    data.level5BestTime = Timer.GetComponent<TimeController>().timeLeftSeconds;
                    TextMeshProUGUI text = endscreen.GetComponentInChildren<TextMeshProUGUI>();
                    text.text += "\nNew Best Time: " + TimeSpan.FromSeconds(data.level5BestTime).ToString("ss'.'ff");
                }
                break;
        }
        endscreen.SetActive(true);
    }

    private void checkTime()
    {
        if(Timer.GetComponent<TimeController>().timeLeftSeconds <=0) {
            looseScreen.SetActive(true);
        }
    }

    
}
