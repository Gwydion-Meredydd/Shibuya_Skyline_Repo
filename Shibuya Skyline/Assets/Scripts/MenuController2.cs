using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController2 : MonoBehaviour {
    public Animator Animator;
    public GameObject QuitMenu;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }
    void Play()
    {
        Animator.SetBool("Play", true); 
    }
    void Settings()
    {
        Animator.SetBool("SettingsBack", false);
        Animator.SetBool("Settings", true);
    }
    void Help()
    {
        Animator.SetBool("Help2", false);
        Animator.SetBool("Help", true);
    }
    public void SettingsBack()
    {
        Debug.Log("METHOD CALLED");
        Animator.SetBool("SettingsBack", true);
        Animator.SetBool("Settings", false);
    }
    void HelpBack()
    {
        Animator.SetBool("Help2", true);
        Animator.SetBool("Help", false);
    }
    void Quit()
    {
        QuitMenu.SetActive(true);
    }
}
