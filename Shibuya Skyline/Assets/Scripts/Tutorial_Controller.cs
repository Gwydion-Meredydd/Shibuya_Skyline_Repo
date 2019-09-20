using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Controller : MonoBehaviour
{
    public GameObject CurrentText;
    public GameObject NextText;
    public GameObject Player;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("zero");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            NextText.SetActive(true);
            CurrentText.SetActive(false);
        }
    }

}
