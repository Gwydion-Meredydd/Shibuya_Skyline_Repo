using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Pause_Menu_Controller : MonoBehaviour
{
    public GameObject PauseControler;
    public GameObject PauseMenu;
    public GameObject GameSettings;
    public GameObject VideoSettings;
    public GameObject PauseMenuCamera;
    public GameObject PauseOption;
    public GameObject VideoSettingsOption;
    public GameObject GameSettingsOption;
    public EventSystem EventSystems;
    public GameObject Player;

    void Start()
    {
        EventSystems.SetSelectedGameObject(PauseOption, null);
    }
    public void Update()
    {
        //Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
    }
    public void Resume()
    {
        PauseControler.SendMessage("PauseReturn");
       
}
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void High_Score()
    {
        SceneManager.LoadScene("Score");
    }
    public void Game_Settings()
    {
        GameSettings.SetActive(true);
        EventSystems.SetSelectedGameObject(GameSettingsOption, null);
        PauseMenu.SetActive(false);
    }
    public void Video_Settings()
    {
        VideoSettings.SetActive(true);
        EventSystems.SetSelectedGameObject(VideoSettingsOption, null);
        PauseMenu.SetActive(false);
    }
    public void Main_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
