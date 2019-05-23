using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject Parent;
    public GameObject Player;

    void Start()
    {
        Parent = GameObject.Find("FPSController");
        Player = GameObject.Find("zero");
    }
    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        Parent.SendMessage("DeathOn");
        Player.SendMessage("DeathOn");
    }
    void OnTriggerExit(Collider other)
    {
        Parent.SendMessage("DeathOff");
        Player.SendMessage("DeathOff");
    }
}
