using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_DOWN : MonoBehaviour {
    public bool E_Pressed;
    public GameObject Zero;
    // Use this for initialization
    void Start()
    {
        Zero = GameObject.Find("zero");
    }
	
	// Update is called once per frame
	void Update () {
 
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e") || Input.GetKeyDown("joystick button 1"))
            {
                E_Pressed = true;
            }
            if (Input.GetKeyUp("e") || Input.GetKeyDown("joystick button 1"))
            {
                E_Pressed = false;
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            if (E_Pressed == false)
            {
                Zero = GameObject.Find("zero");
                Zero.SendMessage("Death");
            }
        }

    }
}
