using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint_Manager1 : MonoBehaviour {

    public GameObject W_1;
    public GameObject W_2;
    public GameObject W_3;
    public GameObject W_4;
    public GameObject W_5;
    public GameObject W_6;
    public GameObject W_7;
    public GameObject W_8;
    public GameObject W_9;
    public GameObject W_10;
    public GameObject W_11;
    public GameObject W_12;
    public GameObject W_13;
    public GameObject SoundEffect;

    public void Waypoint_1()
    {
        StartCoroutine(WayPoint1());
        W_2.SetActive(true);
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_2()
    {
        W_3.SetActive(true);
        StartCoroutine(WayPoint2());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_3()
    {
        W_4.SetActive(true);
        StartCoroutine(WayPoint3());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_4()
    {
        W_5.SetActive(true);
        StartCoroutine(WayPoint4());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_5()
    {
        W_6.SetActive(true);
        StartCoroutine(WayPoint5());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_6()
    {
        W_7.SetActive(true);
        StartCoroutine(WayPoint6());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_7()
    {
        W_8.SetActive(true);
        StartCoroutine(WayPoint7());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_8()
    {
        W_9.SetActive(true);
        StartCoroutine(WayPoint8());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_9()
    {
        W_10.SetActive(true);
        StartCoroutine(WayPoint9());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_10()
    {
        W_11.SetActive(true);
        StartCoroutine(WayPoint10());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_11()
    {
        W_12.SetActive(true);
        StartCoroutine(WayPoint11());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_12()
    {
        W_13.SetActive(true);
        StartCoroutine(WayPoint12());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
    }
    public void Waypoint_13()
    {
        StartCoroutine(WayPoint13());
        SoundEffect.SetActive(false);
        StartCoroutine(Timer());
        // W_14.SetActive(true);
    }
    IEnumerator WayPoint1()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_1.SetActive(false);
    }
    IEnumerator WayPoint2()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_2.SetActive(false);
    }
    IEnumerator WayPoint3()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_3.SetActive(false);
    }
    IEnumerator WayPoint4()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_4.SetActive(false);
    }
    IEnumerator WayPoint5()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_5.SetActive(false);
    }
    IEnumerator WayPoint6()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_6.SetActive(false);
    }
    IEnumerator WayPoint7()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_7.SetActive(false);
    }
    IEnumerator WayPoint8()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_8.SetActive(false);
    }
    IEnumerator WayPoint9()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_9.SetActive(false);
    }
    IEnumerator WayPoint10()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_10.SetActive(false);
    }
    IEnumerator WayPoint11()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_11.SetActive(false);
    }
    IEnumerator WayPoint12()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_12.SetActive(false);
    }
    IEnumerator WayPoint13()
    {
        yield return new WaitForSecondsRealtime(5f);
        W_13.SetActive(false);
    }
    IEnumerator Timer()
    {
        SoundEffect.SetActive(true);
        yield return new WaitForSecondsRealtime(3.3f);
        SoundEffect.SetActive(false);
    }



}
