using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Controller : MonoBehaviour
{
    public GameObject CurrentText;
    public GameObject NextText;
    private void OnTriggerEnter(Collider other)
    {
        NextText.SetActive(true);
        CurrentText.SetActive(false);
    }

}
