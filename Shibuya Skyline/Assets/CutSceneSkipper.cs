using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneSkipper : MonoBehaviour
{
    public Animator Animator;
    public GameObject CutSceneCam;
    public GameObject SkipText1;
    public GameObject SkipText2;
    public GameObject PauseMenu;

    public void Start()
    {
        StartCoroutine(TimerSwitch());
    }
    public void Update()
    {
        if (Input.GetKey("joystick button 0"))
        {
            StartCoroutine(Timer());
            Animator.SetBool("Skip", true);
        }
    }
    public void PauseTimerLink()
    {
        Animator.SetBool("Skip", true);
    }
    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        CutSceneCam.SetActive(false);
        PauseMenu.SetActive(true);
        SkipText1.SetActive(false);
        SkipText2.SetActive(false);

    }
    IEnumerator TimerSwitch()
    {
        yield return new WaitForSecondsRealtime(10);
        PauseMenu.SetActive(true);
        CutSceneCam.SetActive(false);
        SkipText1.SetActive(false);
        SkipText2.SetActive(false);

    }
}
