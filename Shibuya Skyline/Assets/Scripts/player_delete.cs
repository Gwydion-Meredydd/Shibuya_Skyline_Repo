using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_delete : MonoBehaviour {

    public GameObject Player;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("zero");
        Player.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
