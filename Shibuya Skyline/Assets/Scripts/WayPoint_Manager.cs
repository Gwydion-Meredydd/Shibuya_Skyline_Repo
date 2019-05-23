using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint_Manager : MonoBehaviour {

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

    public void Waypoint_1()
    {
        W_1.SetActive(false);
        W_2.SetActive(true);
    }
    public void Waypoint_2()
    {
        W_2.SetActive(false);
        W_3.SetActive(true);
    }
    public void Waypoint_3()
    {
        W_3.SetActive(false);
        W_4.SetActive(true);
    }
    public void Waypoint_4()
    {
        W_4.SetActive(false);
        W_5.SetActive(true);
        W_10.SetActive(true);
    }
    public void Waypoint_5()
    {
        W_5.SetActive(false);
        W_10.SetActive(false);
        W_6.SetActive(true);
    }
    public void Waypoint_6()
    {
        W_6.SetActive(false);
        W_7.SetActive(true);
    }
    public void Waypoint_7()
    {
        W_7.SetActive(false);
        W_8.SetActive(true);
    }
    public void Waypoint_8()
    {
        W_8.SetActive(false);
        W_9.SetActive(true);
    }
    public void Waypoint_9()
    {
        W_9.SetActive(false);
        W_10.SetActive(true);
    }
    public void Waypoint_10()
    {
        W_5.SetActive(false);
        W_10.SetActive(false);
        W_11.SetActive(true);
    }
    public void Waypoint_11()
    {
        W_11.SetActive(false);
        W_12.SetActive(true);
    }
    public void Waypoint_12()
    {
        W_12.SetActive(false);
        W_13.SetActive(true);
    }
    public void Waypoint_13()
    {
        W_13.SetActive(false);
       // W_14.SetActive(true);
    }



}
