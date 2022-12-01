using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeController : MonoBehaviour
{
    private TimeSpan timeLeft;
    private bool timerGoing;

    public float timeLeftSeconds;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        BeginTimer();
    }
    public void BeginTimer()
    {
        timerGoing = true;
        

        StartCoroutine(UpdateTimer());
    }
    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            timeLeftSeconds -= Time.deltaTime;
            timeLeft = TimeSpan.FromSeconds(timeLeftSeconds);
            string timeStr = timeLeft.ToString("mm':'ss'.'ff");
            timerText.text = timeStr;

            if(timeLeftSeconds < 0)
            {
                EndTimer();
            }

            yield return null;
        }
    }
    public void EndTimer()
    {
        timerGoing = false;      
    }
}
