using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class window : MonoBehaviour {

    public GameObject WindowSmash;
    public GameObject Zero;
    // Use this for initialization
    void Start()
    {
        Zero = GameObject.Find("zero");
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            WindowSmash.SetActive(true);
            Destroy(gameObject);
            
        }

    }

}