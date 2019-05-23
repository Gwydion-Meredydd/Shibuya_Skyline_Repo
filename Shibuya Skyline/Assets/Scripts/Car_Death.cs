using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Death : MonoBehaviour {
    public GameObject Zero;
    // Use this for initialization
    void Start () {
        Zero = GameObject.Find("zero");

    }
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider  other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            Zero = GameObject.Find("zero");
            Zero.SendMessage("Death");
        }

    }

}