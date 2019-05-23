using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vault_Script : MonoBehaviour
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
        Player = GameObject.Find("zero");
        Player.SendMessage("Vault_Entered");
    }
    private void OnTriggerExit(Collider other)
    {
        Player = GameObject.Find("zero");
        Player.SendMessage("Vault_Exit");
    }
}
