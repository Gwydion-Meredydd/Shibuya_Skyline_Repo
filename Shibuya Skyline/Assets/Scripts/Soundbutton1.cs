using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundbutton1 : MonoBehaviour {

    public GameObject MouseOver; // higlight object
    public GameObject SoundBar1; // icon object
    public GameObject SoundBar2; // icon object   
    public GameObject SoundBar3; // icon object
    public GameObject SoundCross; // icon object
    public AudioSource Wind;
    int check1 = 0; //reset cehck for button
    int check2 = 1; //icon state check 0/4


    public void OnMouseDown()
    {
        if (check1 == 0) //button reset checker
        {
            Debug.Log("1");
            if (check2 == 0) //checks the icon state
            {
                Debug.Log("2");
                check1 = 1;
                SoundBar1.SetActive(true); //sets icon bars to true/false
                SoundBar2.SetActive(true);
                SoundBar3.SetActive(true);
                SoundCross.SetActive(false);
                Wind.volume = 0.2f; //sets volume

                check2 = 1;
                StartCoroutine(Delay());
            }
        }
        if (check1 == 0)
        {
            if (check2 == 1) //checks the icon state
            {
                Debug.Log("3");
                check1 = 1;
                SoundBar1.SetActive(true); //sets icon bars to true/false
                SoundBar2.SetActive(true);
                SoundBar3.SetActive(false);
                SoundCross.SetActive(false);
                Wind.volume = 0.1f; //sets volume
                check2 = 2;
                StartCoroutine(Delay());
            }
        }
        if (check1 == 0)
        {
            if (check2 == 2) //checks the icon state
            {
                Debug.Log("4");
                check1 = 1;
                SoundBar1.SetActive(true); //sets icon bars to true/false
                SoundBar2.SetActive(false);
                SoundBar3.SetActive(false);
                SoundCross.SetActive(false);
                Wind.volume = 0.05f; //sets volume
                check2 = 3;
                StartCoroutine(Delay());
            }
        }
        if (check1 == 0)
        {
            if (check2 == 3) //checks the icon state
            {
                Debug.Log("5");
                check1 = 1;
                SoundBar1.SetActive(false); //sets icon bars to true/false
                SoundBar2.SetActive(false);
                SoundBar3.SetActive(false);
                SoundCross.SetActive(true);
                Wind.volume = 0.0f; //sets volume
                check2 = 0;
                StartCoroutine(Delay());
            }
        }
    }
    IEnumerator Delay()//button reset scripts
    {
        Debug.Log("7");
        yield return new WaitForSeconds(0.1f);
        check1 = 0;
    }
    public void OnMouseOver()
    {
        MouseOver.SetActive(true);
    }
    public void OnMouseExit()
    {
        MouseOver.SetActive(false);
    }
}
