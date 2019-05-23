using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quality_script : MonoBehaviour {

    public GameObject DropDown;
    public void Quality()
    {
        if (DropDown.activeInHierarchy == false)
        {
            DropDown.SetActive(true);
        }
        else if (DropDown.activeInHierarchy == true)
        {
            DropDown.SetActive(false);
        }
    }
}
