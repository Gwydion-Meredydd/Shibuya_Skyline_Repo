using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Play1()
    {
        SceneManager.LoadScene("Test");
    }
    public void Play2()
    {
        SceneManager.LoadScene("Lvl2_BlockOut");
    }

    public void Reset()
    {
        PlayerPrefs.SetFloat("S_Score", 0);
        PlayerPrefs.SetFloat("S_Score2", 0);
        PlayerPrefs.SetFloat("H_Score", 0);
        PlayerPrefs.SetFloat("H_Score2", 0);
    }
}
