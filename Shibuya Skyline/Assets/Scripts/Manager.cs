using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Test");
    }
    public void Reset()
    {
        PlayerPrefs.SetFloat("H_Score", 0);
    }
}
