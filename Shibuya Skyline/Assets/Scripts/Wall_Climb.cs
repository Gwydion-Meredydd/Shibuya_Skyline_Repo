using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Climb : MonoBehaviour {

    public GameObject Player;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("zero");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Player.SendMessage("Climb_Enter");
    }
    private void OnTriggerExit(Collider other)
    {
        Player.SendMessage("Climb_Exit");
    }
}
