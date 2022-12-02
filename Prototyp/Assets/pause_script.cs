using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_script : MonoBehaviour
{
    [SerializeField]
    GameObject pause;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Debug.Log("Pause");
            pause_menu();
        }
    }
    private void pause_menu()
    {
        pause.SetActive(true);
    }
    public void end_pause()
    {
        pause.SetActive(false);
    }
}
