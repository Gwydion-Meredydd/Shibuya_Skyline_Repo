using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour {
    public GameObject Click;
    public GameObject LevelSelect;
    public GameObject VideoSettings;
    public GameObject MainMenu;
    public GameObject Controls;
    public GameObject QuitMenu;
    [Space]
    public Animator Animator;
    [Space]
    public GameObject LevelSelectOption;
    public GameObject MainMenuOption;
    public GameObject ControlsOption;
    public GameObject QuitMenuOption;
    public EventSystem EventSystems;
    public void Play()
    {
        
        LevelSelect.SetActive(true);
        EventSystems.SetSelectedGameObject(LevelSelectOption,null);
        MainMenu.SetActive(false);
        Click.SetActive(true);
        StartCoroutine(audio());
        Animator.SetBool("Controls", false);
        Animator.SetBool("Settings", false);
        Animator.SetBool("Quit", false);
        Animator.SetBool("Level", true);
        EventSystems.SetSelectedGameObject(LevelSelectOption, null);
    }
    public void Controler()
    {

        MainMenu.SetActive(false);
        Controls.SetActive(true);
        EventSystems.SetSelectedGameObject(ControlsOption, null);
        Click.SetActive(true);
        StartCoroutine(audio());
        Animator.SetBool("Settings", false);
        Animator.SetBool("Quit", false);
        Animator.SetBool("Level", false);
        Animator.SetBool("Controls", true);
    }
    public void Settings()
    {
        MainMenu.SetActive(false);
        VideoSettings.SetActive(true);
        Click.SetActive(true);
        StartCoroutine(audio());
        Animator.SetBool("Controls", false);
        Animator.SetBool("Quit", false);
        Animator.SetBool("Level", false);
        Animator.SetBool("Settings", true);
    }
    public void Back()
    {
        MainMenu.SetActive(true);
        Click.SetActive(true);
        StartCoroutine(audio());
        Animator.SetBool("Controls", false);
        Animator.SetBool("Settings", false);
        Animator.SetBool("Quit", false);
        Animator.SetBool("Level", false);
        Animator.SetBool("Back", true);
        StartCoroutine(BackOff());
    }
    public void Quit()
    {
        QuitMenu.SetActive(true);
        MainMenu.SetActive(false);
        EventSystems.SetSelectedGameObject(QuitMenuOption, null);
        Click.SetActive(true);
        StartCoroutine(audio());
        Animator.SetBool("Controls", false);
        Animator.SetBool("Settings", false);
        Animator.SetBool("Level", false);
        Animator.SetBool("Quit", true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void HighScores()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        SceneManager.LoadScene("Score");
    }
    public void Credits()
    {
        Click.SetActive(true);
        StartCoroutine(audio());
        SceneManager.LoadScene("Credits");
    }
    IEnumerator BackOff()
    {
        yield return new WaitForSecondsRealtime(1);
        Animator.SetBool("Back", false);
        LevelSelect.SetActive(false);
        Controls.SetActive(false);
        QuitMenu.SetActive(false);
        VideoSettings.SetActive(false);
        EventSystems.SetSelectedGameObject(MainMenuOption, null);
    }
    IEnumerator SubOff()
    {
        yield return new WaitForSecondsRealtime(0.6f);
        MainMenu.SetActive(false);
        LevelSelect.SetActive(false);
        Controls.SetActive(false);
        QuitMenu.SetActive(false);
        VideoSettings.SetActive(false);
    }
    IEnumerator audio()
    {
        yield return new WaitForSecondsRealtime(0.4f);
        Click.SetActive(false);
    }
}
