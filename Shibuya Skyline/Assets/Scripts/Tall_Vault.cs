using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tall_Vault : MonoBehaviour
{

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
        if (other.gameObject.CompareTag("Player"))
        {
            Player = GameObject.Find("zero");
            Player.SendMessage("Tall_Vault_Entered");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            Player.SendMessage("Tall_Vault_Exit");

        }
    }
}
