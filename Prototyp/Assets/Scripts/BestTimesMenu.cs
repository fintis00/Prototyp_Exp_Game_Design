using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BestTimesMenu : MonoBehaviour
{
    public DataScriptableObject data;
    public TextMeshProUGUI bestTimeLevel1;
    public TextMeshProUGUI bestTimeLevel2;
    public TextMeshProUGUI bestTimeLevel3;
    public TextMeshProUGUI bestTimeLevel4;
    public TextMeshProUGUI bestTimeLevel5;
    private TimeSpan timespan;
    void Start()
    {
        timespan = TimeSpan.FromSeconds(data.level1BestTime);
        bestTimeLevel1.text = "Level 1: " + timespan.ToString("ss'.'ff");
        timespan = TimeSpan.FromSeconds(data.level2BestTime);
        bestTimeLevel2.text = "Level 2: " + timespan.ToString("ss'.'ff");
        timespan = TimeSpan.FromSeconds(data.level3BestTime);
        bestTimeLevel3.text = "Level 3: " + timespan.ToString("ss'.'ff");
        timespan = TimeSpan.FromSeconds(data.level4BestTime);
        bestTimeLevel4.text = "Level 4: " + timespan.ToString("ss'.'ff");
        timespan = TimeSpan.FromSeconds(data.level5BestTime);
        bestTimeLevel5.text = "Level 5: " + timespan.ToString("ss'.'ff");
    }
}
