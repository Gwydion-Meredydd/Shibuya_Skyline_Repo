using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windowd : MonoBehaviour {
    public GameObject Resolution;
    public void Windowed()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Debug.Log("Window Message sent");
        Resolution.SendMessage("Check2");
    }
}
