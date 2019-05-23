using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityStandardAssets.ImageEffects;

public class VideoSettings : MonoBehaviour {
    public GameObject VideoSettingsMenu;
    public GameObject PauseMenu;
    [Space]
    public Slider GraphicsSlider;
    public Slider ResolutionSlider;
    public Slider ReflectionsSlider;
    public Slider EdgeSlider;
    [Space]
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    [Space]
    public GameObject Reflections;
    public GameObject PauseOption;
    public EventSystem EventSystems;
    public GameObject Camera;
    
    void Update()
    {
        if (Screen.fullScreen == false)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(true);
            Text5.SetActive(true);
            Text6.SetActive(true);
           
            Debug.Log("fullscreen Message sent");

        }
        else
        {
            Text1.SetActive(true);
            Text2.SetActive(true);
            Text3.SetActive(true);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
       
            Debug.Log("else fullscreen Message sent");
        }
    }
    public void BackButton()
    {
        PauseMenu.SetActive(true);
        EventSystems.SetSelectedGameObject(PauseOption, null);
        VideoSettingsMenu.SetActive(false);
    }
    public void Edge_Slider()
    {
        if (EdgeSlider.value == 1)
        {
            Camera.GetComponent<EdgeDetection>().enabled = true;
        }
        if (EdgeSlider.value == 0)
        {
            
            Camera.GetComponent<EdgeDetection>().enabled = false;
        }
    }
    public void fullScreenButton()
    {
        if (Screen.fullScreen == false)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(true);
            Text5.SetActive(true);
            Text6.SetActive(true);
            Screen.fullScreen = true;
            Debug.Log("fullscreen Message sent");

        }
        else
        {
            Text1.SetActive(true);
            Text2.SetActive(true);
            Text3.SetActive(true);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
            Screen.fullScreen = false;
            Debug.Log("else fullscreen Message sent");
        }
    }
    public void Graphics_Slider()
    {
        if (GraphicsSlider.value == 0)
        {
            QualitySettings.SetQualityLevel(1);
        }
        if (GraphicsSlider.value == 1)
        {
            QualitySettings.SetQualityLevel(2);
        }
        if (GraphicsSlider.value == 2)
        {
            QualitySettings.SetQualityLevel(3);
        }
        if (GraphicsSlider.value == 3)
        {
            QualitySettings.SetQualityLevel(4);
        }
        if (GraphicsSlider.value == 4)
        {
            QualitySettings.SetQualityLevel(5);
        }
        if (GraphicsSlider.value == 5)
        {
            QualitySettings.SetQualityLevel(6);
        }
        if (GraphicsSlider.value == 6)
        {
            QualitySettings.SetQualityLevel(7);
        }
        if (GraphicsSlider.value == 7)
        {
            QualitySettings.SetQualityLevel(8);
        }
    }
    public void Resolution_Slider()
    {
        if (ResolutionSlider.value == 0)
        {
            Screen.SetResolution(1024, 576, false);
        }
        if (ResolutionSlider.value == 1)
        {
            Screen.SetResolution(1152, 648, false);
        }
        if (ResolutionSlider.value == 2)
        {
            Screen.SetResolution(1280, 720, false);
        }
        if (ResolutionSlider.value == 3)
        {
            Screen.SetResolution(1366, 768, false);
        }
        if (ResolutionSlider.value == 4)
        {
            Screen.SetResolution(1600, 900, false);
        }
        if (ResolutionSlider.value == 5)
        {
            Screen.SetResolution(1920, 1080, false);
        }
        if (ResolutionSlider.value == 6)
        {
            Screen.SetResolution(2560, 1440, false);
        }
        if (ResolutionSlider.value == 7)
        {
            Screen.SetResolution(3840, 2160, false);
        }
        if (ResolutionSlider.value == 8)
        {
            Screen.SetResolution(7680, 4320, false);
        }
    }
    public void Reflections_Slider()
    {
        if (ReflectionsSlider.value == 0)
        {
            Reflections.SetActive(false);
        }
        if (ReflectionsSlider.value == 1)
        {
            Reflections.SetActive(true);
        }
    }
}
