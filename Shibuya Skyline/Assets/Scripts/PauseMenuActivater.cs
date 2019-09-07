using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenuActivater : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public GameObject PauseMenu;
    public GameObject VideoMenu;
    public GameObject ControlMenu;
    public GameObject GameMenu;
    public GameObject Win;
    public GameObject PauseOption;
    public GameObject ControlsOption;
    public GameObject GameOption;
    public GameObject VideoOption;
    public EventSystem EventSystems;
    public int check1 = 1;
    public int check2 = 1;
    public int check3 = 1;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) || Input.GetKey("p")||Input.GetKeyDown("joystick button 7"))
        {
            KEYPRESSED();

        }

    }
    public void KEYPRESSED()
    {
        if (check3 == 1)
        {
            if (check1 == 1)
            {
                if (check2 == 1)
                {
                    check1 = 2;
                    PauseEnable();
                }
                if (check2 == 2)
                {
                    check1 = 2;
                    PauseReturn();
                }
            }
        }
    }
    IEnumerator Delay()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        check1 = 1;
        check3 = 1;
    }
    IEnumerator check5()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        check2 = 2;
        check3 = 1;
    }
    IEnumerator check4()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(1);
        check2 = 1;
        check3 = 1;
    }
    public void PauseEnable()
    {
        check3 = 2;
        Player.SetActive(false);
        Camera.SetActive(true);
        PauseMenu.SetActive(true);
        EventSystems.SetSelectedGameObject(PauseOption, null);
        StartCoroutine(Delay());
        StartCoroutine(check5());
        EventSystems.SetSelectedGameObject(PauseOption, null);
    }

    public void PauseReturn()
    {
        
        PauseMenu.SetActive(false);
        VideoMenu.SetActive(false);
        ControlMenu.SetActive(false);
        GameMenu.SetActive(false);
        check3 = 1;
        check2 = 1;
        check1 = 1;
        Camera.SetActive(false);
        Player.SetActive(true);
        Player.SendMessage("PauseTimerLink");
        Win.SendMessage("PauseTimerLink");
        Win.SendMessage("KickStart");
        PauseMenu.SetActive(false);
        VideoMenu.SetActive(false);
        ControlMenu.SetActive(false);
        GameMenu.SetActive(false);
        StartCoroutine(Delay());
        StartCoroutine(check4());
    }

    public void VideoSettings()
    {

    }
}
