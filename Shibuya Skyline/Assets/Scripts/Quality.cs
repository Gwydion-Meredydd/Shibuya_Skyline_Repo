using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quality : MonoBehaviour
{
    public GameObject DropDownMenu;
    Slider m_Dropdown;
    //This is the string that stores the current selection m_Text of the Dropdown
    int m_DropdownValue;

    void Start()
    {
        m_Dropdown = GetComponent<Slider>();
        Debug.Log("Starting Dropdown Value : " + m_Dropdown.value);
    }

    void Update()
    {
 
    }

    public void ScreenResOne()
    {
        if (m_Dropdown.value == 0)
        {
            QualitySettings.SetQualityLevel(1);
        }
        if (m_Dropdown.value == 1)
        {
            QualitySettings.SetQualityLevel(2);
        }
        if (m_Dropdown.value == 2)
        {
            QualitySettings.SetQualityLevel(3);
        }
        if (m_Dropdown.value == 3)
        {
            QualitySettings.SetQualityLevel(4);
        }
        if (m_Dropdown.value == 4)
        {
            QualitySettings.SetQualityLevel(5);
        }
        if (m_Dropdown.value == 5)
        {
            QualitySettings.SetQualityLevel(6);
        }
        if (m_Dropdown.value == 6)
        {
            QualitySettings.SetQualityLevel(7);
        }
        if (m_Dropdown.value == 7)
        {
            QualitySettings.SetQualityLevel(8);
        }
    }
}
