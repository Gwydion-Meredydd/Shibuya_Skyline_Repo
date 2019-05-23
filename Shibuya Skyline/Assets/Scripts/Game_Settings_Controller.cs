using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class Game_Settings_Controller : MonoBehaviour
{
    public GameObject Pause_Menu;
    public GameObject GameSettings_Menu;
    public GameObject Controls_Menu;
    public EventSystem EventSystems;
    [Space]
    public GameObject Cars;
    public Slider Audio_Slider;
    public Slider Music_Slider;
    public Slider Fov_Slider;
    [Space]
    public AudioSource Audio1;
    public AudioSource Audio2;
    public AudioSource Audio3;
    public AudioSource Audio4;
    [Space]
    public AudioSource Music1;
    [Space]
    public Camera Camera1;
    public GameObject PauseOption;
    public GameObject ControlsOption;

    void Start()
    {
        Cars = GameObject.FindGameObjectWithTag("car");
        Cars.GetComponent<AudioSource>();

    }
    void Update()
    {
        Cars = GameObject.FindGameObjectWithTag("car");
        Cars.GetComponent<AudioSource>();
    }
    public void BackButton()
    {
        Pause_Menu.SetActive(true);
        EventSystems.SetSelectedGameObject(PauseOption, null);
        GameSettings_Menu.SetActive(false);
    }

    public void AudioSlider()
    {
        Audio1.volume = Audio_Slider.value;
        Audio2.volume = Audio_Slider.value;
        Audio3.volume = Audio_Slider.value;
        Audio4.volume = Audio_Slider.value;
    }

    public void MusicSlider()
    {
        Music1.volume = Music_Slider.value;
    }
    
    public void FovSlider()
    {
        Camera1.fieldOfView = Fov_Slider.value;
    }
    
    public void ControlsButton()
    {
        Controls_Menu.SetActive(true);
        EventSystems.SetSelectedGameObject(ControlsOption, null);
        GameSettings_Menu.SetActive(false);
    }
    
}
