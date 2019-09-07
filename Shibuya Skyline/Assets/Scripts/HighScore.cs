using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    public  float Score;
    public float Score2;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;

    // Use this for initialization
    void Start ()
    {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Score = PlayerPrefs.GetFloat("S_Score");
            if (Score > PlayerPrefs.GetFloat("H_Score"))
            {

                PlayerPrefs.SetFloat("H_Score", Score);
            }
            text1.text = PlayerPrefs.GetFloat("H_Score").ToString();
            text2.text = PlayerPrefs.GetFloat("H_Score").ToString();

            text3.text = PlayerPrefs.GetFloat("S_Score", Score).ToString();
            text4.text = PlayerPrefs.GetFloat("S_Score", Score).ToString();
        Score2 = PlayerPrefs.GetFloat("S_Score2");
        if (Score2 > PlayerPrefs.GetFloat("H_Score2"))
        {

            PlayerPrefs.SetFloat("H_Score2", Score2);
        }
        text5.text = PlayerPrefs.GetFloat("H_Score2").ToString();
        text6.text = PlayerPrefs.GetFloat("H_Score2").ToString();

        text7.text = PlayerPrefs.GetFloat("S_Score2", Score2).ToString();
        text8.text = PlayerPrefs.GetFloat("S_Score2", Score2).ToString();

    }
}
