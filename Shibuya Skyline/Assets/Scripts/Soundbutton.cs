using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundbutton : MonoBehaviour {

    public GameObject MouseOver; // higlight object
    public GameObject SoundBar1; // icon object
    public GameObject SoundBar2; // icon object   
    public GameObject SoundBar3; // icon object
    public GameObject SoundCross; // icon object
    public AudioSource Planks1; //audio
    public AudioSource Planks2; //audio
    public AudioSource Planks3; //audio 
    public AudioSource Planks4; //audio
    public AudioSource Light1; //audio
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
                Planks1.volume = 1f; //sets volume
                Planks2.volume = 1f;
                Planks3.volume = 1f;
                Planks4.volume = 1f;
                Planks4.volume = 1f;
                Light1.volume = 1f;
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
                Planks1.volume = 0.70f; //sets volume
                Planks2.volume = 0.70f;
                Planks3.volume = 0.70f;
                Planks4.volume = 0.70f;
                Planks4.volume = 0.70f;
                Light1.volume = 0.70f;
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
                Planks1.volume = 0.35f; //sets volume
                Planks2.volume = 0.35f;
                Planks3.volume = 0.35f;
                Planks4.volume = 0.35f;
                Planks4.volume = 0.35f;
                Light1.volume = 0.35f;
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
                Planks1.volume = 0f; //sets volume
                Planks2.volume = 0f;
                Planks3.volume = 0f;
                Planks4.volume = 0f;
                Planks4.volume = 0f;
                Light1.volume = 0f;
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
