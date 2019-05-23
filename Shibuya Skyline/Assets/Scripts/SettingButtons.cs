using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingButtons : MonoBehaviour
	{
    public Transform Door;
    public Transform Cam1;
    public Animator Animator;

    public void BackButton()
    {
        Debug.Log("Camera Message sent");
        Cam1.SendMessage("SettingsBack");
        Door.SendMessage("SettingsBack");

    } 
    public void BACK()
    {
        Animator.SetBool("Pause", true);
        Animator.SetBool("Pause2", false);
    }
    public void BACK2()
    {
        Animator.SetBool("Pause2", true);
        Animator.SetBool("Pause", false);
    }
}
