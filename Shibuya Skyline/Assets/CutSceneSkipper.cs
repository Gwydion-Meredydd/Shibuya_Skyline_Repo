using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneSkipper : MonoBehaviour
{
    public Animator FpsAnimator;
    public Animator Animator;
    public GameObject Zero;
    public GameObject CutSceneCam;
    public GameObject SkipText1;
    public GameObject SkipText2;
    public GameObject PauseMenu;
    private bool Check;

    void Start()
    {
        StartCoroutine(TimerSwitch());
        Check = false;
    }
    public void Update()
    {
        if (Check == false)
        {
            if (Input.GetKey("joystick button 0"))
            {
                StartCoroutine(Timer());
                FpsAnimator.SetBool("Skip", true);
                Animator.SetBool("Skip", true);
                Check = true;
            }
        }
    }
    public void PauseTimerLink()
    {
        FpsAnimator.SetBool("Skip", true);
        Animator.SetBool("Skip", true);
    }
    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        CutSceneCam.SetActive(false);
        Zero.SendMessage("CutSceneReseting");
        PauseMenu.SetActive(true);
        SkipText1.SetActive(false);
        SkipText2.SetActive(false);

    }
    IEnumerator TimerSwitch()
    {
        if (Check == false)
        {
            yield return new WaitForSeconds(10);
            if (Check == false)
            {
                Check = true;
                PauseMenu.SetActive(true);
                Zero.SendMessage("CutSceneReseting");
                CutSceneCam.SetActive(false);
                SkipText1.SetActive(false);
                SkipText2.SetActive(false);
            }
        }

    }
}
