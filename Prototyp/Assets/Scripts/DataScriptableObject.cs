using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DataScriptableObject : ScriptableObject
{
    public bool menu_first_visit = true;

    public bool level2Unlocked;
    public bool level3Unlocked;
    public bool level4Unlocked;
    public bool level5Unlocked;

    public float level1BestTime;
    public float level2BestTime;
    public float level3BestTime;
    public float level4BestTime;
    public float level5BestTime;
}
