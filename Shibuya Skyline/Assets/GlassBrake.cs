using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBrake : MonoBehaviour
{
    public GameObject BrokenGlass;
    public GameObject SolidGlass;
    public GameObject Zero;
    public GameObject Zero2;
    public GameObject Player;
    public GameObject FlyCam;

    void Start()
    {
        StartCoroutine(Time());
        
    }
    IEnumerator Time()
    {
        yield return new WaitForSecondsRealtime(4.8f);
        Zero.SendMessage("Jump");
        yield return new WaitForSecondsRealtime(0.8f);
        SolidGlass.SetActive(false);
        BrokenGlass.SetActive(true);
        yield return new WaitForSecondsRealtime(0.8f);
        Zero.SetActive(false);
        Zero2.SetActive(true);
        FlyCam.SetActive(true);
        yield return new WaitForSecondsRealtime(3f);
        Player.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        FlyCam.SetActive(false);
        Zero2.SetActive(false);



    }
}
