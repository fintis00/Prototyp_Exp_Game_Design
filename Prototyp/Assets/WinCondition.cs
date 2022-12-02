using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class WinCondition : MonoBehaviour
{
    bool player1_complete;
    bool player2_complete;

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
        endscreen.SetActive(true);
    }

    private void checkTime()
    {
        if(Timer.GetComponent<TimeController>().timeLeftSeconds <=0) {
            looseScreen.SetActive(true);
        }
    }

    
}
