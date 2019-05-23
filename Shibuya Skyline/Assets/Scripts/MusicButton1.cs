using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButton1 : MonoBehaviour
{
    //public AudioSource Music;
    public AudioSource Music2;
    public GameObject Cross;
    public GameObject MouseOver;
    int check = 0;
    int check2 = 0;
    public void OnMouseDown()
    {
        if (check2 == 0)//allows the buttons to be reset
        {
            if (check == 1)// on off check
            {
                check2 = 1;//button reset switch
                Cross.SetActive(false); // enables disables cross
                check = 0; //reset 
                //Music.volume = 0.106f;//sets volume 
                Music2.volume = 0.835f;//sets volume 
                StartCoroutine(Delay());//starts reset method
            }
        }
        if (check2 == 0)
        {
            if (check == 0)
            {
                check2 = 1;
                Cross.SetActive(true);
                check = 1;
              //  Music.volume = 0f;
                Music2.volume = 0f;
                StartCoroutine(Delay());
            }
        }
    }
    IEnumerator Delay()//button reset scripts
    {
        yield return new WaitForSeconds(0.1f);
        check2 = 0;
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
