using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public GameObject Resolution;
    public void fullScreen()
    {
        Screen.fullScreen = Screen.fullScreen;


        if (Screen.fullScreen == false)
        {
            Screen.fullScreen = true;
            Debug.Log("fullscreen Message sent");
           
        }
        else
        {
            Screen.fullScreen = true;
            Debug.Log("else fullscreen Message sent");
        }
    }
}
