using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdownfunction : MonoBehaviour
{
    public Dropdown m_Dropdown;
    //This is the string that stores the current selection m_Text of the Dropdown
    string m_Message;
    //This Text outputs the current selection to the screen
    public Text m_Text;
    //This is the index value of the Dropdown
    int m_DropdownValue;
    int check1 = 1;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        //m_Dropdown = GetComponent<Dropdown>();
        //Output the first Dropdown index value
        Debug.Log("Starting Dropdown Value : " + m_Dropdown.value);
    }

    void Update()
    {
        m_DropdownValue = m_Dropdown.value;
        if (Screen.fullScreen == true)
        {
            check1 = 1;
        }
        else
        {
            check1 = 2;
        }
    }

    public void Check1()
    {
     //   check1 = 1; //fullscreen check
    }
    public void Check2()
    {
      //  check1 = 2; //windowd 
    }


    // Use this for initialization
    public void ScreenResOne()
    {
        if (check1 == 2)
        {
            Debug.Log("DropDown Fullscreen mode");

            if (m_Dropdown.value == 0)
            {
                Screen.SetResolution(1024, 576, true);
            }
            if (m_Dropdown.value == 1)
            {
                Screen.SetResolution(1152, 648, true);
            }
            if (m_Dropdown.value == 2)
            {
                Screen.SetResolution(1280, 720, true);
            }
            if (m_Dropdown.value == 3)
            {
                Screen.SetResolution(1366, 768, true);
            }
            if (m_Dropdown.value == 4)
            {
                Screen.SetResolution(1600, 900, true);
            }
            if (m_Dropdown.value == 5)
            {
                Screen.SetResolution(1920, 1080, true);
            }
            if (m_Dropdown.value == 6)
            {
                Screen.SetResolution(2560, 1440, true);
            }
            if (m_Dropdown.value == 7)
            {
                Screen.SetResolution(3840, 2160, true);
            }
            if (m_Dropdown.value == 8)
            {
                Screen.SetResolution(7680, 4320, true);
            }
        }
        if (check1 == 1)
        {
            Debug.Log("DropDown windowd mode");
            if (m_Dropdown.value == 0)
            {
                Screen.SetResolution(1024, 576, false);
            }
            if (m_Dropdown.value == 1)
            {
                Screen.SetResolution(1152, 648, false);
            }
            if (m_Dropdown.value == 2)
            {
                Screen.SetResolution(1280, 720, false);
            }
            if (m_Dropdown.value == 3)
            {
                Screen.SetResolution(1366, 768, false);
            }
            if (m_Dropdown.value == 4)
            {
                Screen.SetResolution(1600, 900, false);
            }
            if (m_Dropdown.value == 5)
            {
                Screen.SetResolution(1920, 1080, false);
            }
            if (m_Dropdown.value == 6)
            {
                Screen.SetResolution(2560, 1440, false);
            }
            if (m_Dropdown.value == 7)
            {
                Screen.SetResolution(3840, 2160, false);
            }
            if (m_Dropdown.value == 8)
            {
                Screen.SetResolution(7680, 4320, false);
            }
        }

    }
}
