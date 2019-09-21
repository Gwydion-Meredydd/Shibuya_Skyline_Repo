using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPhysics : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.SendMessage("ElevatorOn");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.SendMessage("ElevatorOff");
        }
    }
}
