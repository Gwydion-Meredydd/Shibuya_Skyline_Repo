using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour {

    public GameObject MouseOver;
    public GameObject DropDownMenu;
    int check = 0;
    int check2 = 0;
    int check3 = 0;

    public void OnMouseDown()
    {
        if (check3 == 1)
        {
            if (check2 == 0)//allows the buttons to be reset
            {
                if (check == 1)// on off check
                {
                    check2 = 1;//button reset switch
                               // DropDownsubmenu.SetActive(false);
                    DropDownMenu.SetActive(false); // enables disables Drop Down Menu
                    check = 0; //reset 
                    StartCoroutine(Delay());//starts reset method
                }
            }
            if (check2 == 0)
            {
                if (check == 0)
                {
                    check2 = 1;
                    DropDownMenu.SetActive(true);
                    check = 1;
                    StartCoroutine(Delay());
                }
            }
        }
    }
    IEnumerator Delay()//button reset scripts
    {
        yield return new WaitForSeconds(0.1f);
        check2 = 0;
    }
    public void OnMouseOver()
    {
        check3 = 1;
        check =0;
        MouseOver.SetActive(true);
    }
    public void OnMouseExit()
    {
        DropDownMenu.SetActive(false); // enables disables Drop Down Menu
        check3 = 0;
        check = 1;
        MouseOver.SetActive(false);
    }
}
