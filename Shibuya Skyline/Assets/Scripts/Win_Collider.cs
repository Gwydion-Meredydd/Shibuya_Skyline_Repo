using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Collider : MonoBehaviour
{

    public GameObject Win;
    public GameObject Reset;
    public GameObject FireWork1;
    public GameObject FireWork2;
    public GameObject FireWork3;
    public GameObject FireWork4;
    public GameObject FireWork5;
    public GameObject Player;

    void Start()
    {
        FireWork1.SetActive(false);
        FireWork2.SetActive(false);
        FireWork3.SetActive(false);
        FireWork4.SetActive(false);
        FireWork5.SetActive(false);
        Reset.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        FireWork1.SetActive(true);
        FireWork2.SetActive(true);
        FireWork3.SetActive(true);
        FireWork4.SetActive(true);
        FireWork5.SetActive(true);
        Win.SetActive(true);
        Reset.SetActive(true);
        Player.SendMessage("Win");
    }
}
