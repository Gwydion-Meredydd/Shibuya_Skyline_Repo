using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Finish : MonoBehaviour
{
    public GameObject Player;
    public GameObject CanvasWin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.SendMessage("ScoreStop");
            CanvasWin.SetActive(true);
        }
    }
}
