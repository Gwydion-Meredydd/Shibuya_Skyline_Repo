using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
    public GameObject GRID1;
    public GameObject GRID2;

    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerEnter(Collider Player)
    {
        GRID1.SetActive(false);
        GRID2.SetActive(true);
    }
    private void OnTriggerExit(Collider Player)
    {
        GRID1.SetActive(true);
        GRID2.SetActive(false);
    }
}
