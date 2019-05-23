using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsDoor : MonoBehaviour {
    public Transform Cam1;
    public Animator Animator;

    public void OnMouseDown()
    {
        Animator.SetBool("SettingsClose", false);
        Cam1.SendMessage("Settings");
        Animator.SetBool("Settings", true);
    }
    public void SettingsBack()
    {
        Animator.SetBool("SettingsClose", true);
        Animator.SetBool("Settings", false);
    }

}
