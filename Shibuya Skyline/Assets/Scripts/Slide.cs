using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour {
    public GameObject Player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        Player.SendMessage("Slide_Entered");
    }
    private void OnTriggerExit(Collider other)
    {
        Player.SendMessage("Slide_Exit");
    }
}
