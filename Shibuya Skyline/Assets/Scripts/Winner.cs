using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Winner : MonoBehaviour {
    public float Time;
    public float Time_Check;
    public float newtime;
    public float Score = 1000000;
    public Text text1;
    public Text text2;
    public Text text3;
    bool Check = false;
    bool Check2 = false;

    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetFloat("S_Score2", 0);
        Check2 = true;
        Check = true;
        Time = 0;
        StartCoroutine(Timer1());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerPrefs.GetFloat("S_Score2"));
        StartCoroutine(Timer3());
        text1.text = Time.ToString();
        text2.text = Time.ToString();
        text3.text = Time.ToString();
        Score2();
        if (Check == false)
        {
            Timer1();
        }
    }
    public void ScoreStop()
    {
       // StopAllCoroutines();
    }

    public void KickStart()
    {
        StartCoroutine(Timer1());
    }
    IEnumerator Timer1()
    {
        if (Check == true)
        {
                Check = true;
                Check2 = true;
            yield return new WaitForSecondsRealtime(1);
            Time = Time + 1;
            StartCoroutine(Timer2());
        }
    }
    IEnumerator Timer2()
    {
        if (Check == true)
        {
            Check2 = true;
            yield return new WaitForSecondsRealtime(1);
            Time = Time + 1;
            StartCoroutine(Timer1());
        }
    }
    IEnumerator Timer3()
    {
        yield return new WaitForSecondsRealtime(1);
        bool Check = true;
    }

        public void Score2()
    {
        newtime = Time + Time;
    }
    public void Win()
    {
        Score = Score - newtime;
        PlayerPrefs.SetFloat("S_Score2", Score);
    }
}
