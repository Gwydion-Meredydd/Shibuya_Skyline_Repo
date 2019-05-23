using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject Click;
    public GameObject Resolution;
    public GameObject AudioIcon1;
    public GameObject AudioIcon2;
    public GameObject AudioIcon3;
    public GameObject AudioIcon4;
    public GameObject MusicIcon1;
    public GameObject MusicIcon2;
    public AudioSource Audio1;
    public AudioSource Music1;
    // Use this for initialization

    public void Windowed()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        if (Screen.fullScreen == true)
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }

    public void Fullscreen()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Screen.fullScreen = Screen.fullScreen;
        if (Screen.fullScreen == false)
        {
            Screen.fullScreen = true;
        }
    }
    public void AudioLevel0()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Audio1.volume = 0f;
        AudioIcon1.SetActive(true);
        AudioIcon2.SetActive(false);
        AudioIcon3.SetActive(false);
        AudioIcon4.SetActive(false);
    }
    public void AudioLevel1()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Audio1.volume = 0.3f;
        AudioIcon1.SetActive(false);
        AudioIcon2.SetActive(true);
        AudioIcon3.SetActive(false);
        AudioIcon4.SetActive(false);
    }
    public void AudioLevel2()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Audio1.volume = 0.6f;
        AudioIcon1.SetActive(false);
        AudioIcon2.SetActive(false);
        AudioIcon3.SetActive(true);
        AudioIcon4.SetActive(false);
    }
    public void AudioLevel3()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Audio1.volume = 1f;
        AudioIcon1.SetActive(false);
        AudioIcon2.SetActive(false);
        AudioIcon3.SetActive(false);
        AudioIcon4.SetActive(true);
    }
    public void Musiclevel0()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Music1.volume = 0f;
        MusicIcon1.SetActive(true);
        MusicIcon2.SetActive(false);
    }
    public void Musiclevel1()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        Music1.volume = 1f;
        MusicIcon1.SetActive(false);
        MusicIcon2.SetActive(true);
    }
    public void GraphicsSlider()
    {

    }
    public void ResolutionSlider()
    {

    }
    IEnumerator audio()
    {
        yield return new WaitForSecondsRealtime(0.4f);
        Click.SetActive(false);
    }
}
