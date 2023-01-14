using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLocks : MonoBehaviour
{
    public int locknumber;
    void Start()
    {
        MainMenu menuscript = GetComponentInParent<MainMenu>();
        DataScriptableObject data = menuscript.data;
        switch (locknumber)
        {
            case 2:
                if(data.level2Unlocked == true)
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    
                    gameObject.SetActive(true);
                }
                break;
            case 3:
                if (data.level3Unlocked == true)
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;
            case 4:
                if (data.level4Unlocked == true)
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;
            case 5:
                if (data.level5Unlocked == true)
                {
                    gameObject.SetActive(false);
                }
                else
                {
                    gameObject.SetActive(true);
                }
                break;
        }
    }
}
