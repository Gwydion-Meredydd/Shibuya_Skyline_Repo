using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Controls : MonoBehaviour
{

    public GameObject GameSettings_Menu;
    public GameObject Control_Menu;
    public GameObject GameOption;
    public EventSystem EventSystems;
    public GameObject Player;
    public Slider YSlider;
    public Slider XSlider;
    public float xsens;
    public float ysens;

    public void Back()
    {
        GameSettings_Menu.SetActive(true);
        EventSystems.SetSelectedGameObject(GameOption, null);

        Control_Menu.SetActive(false);
    }
    public void Y_Slider()
    {
        ysens = YSlider.value;
        Player.SendMessage("y_sens", ysens);
    }
    public void X_Slider()
    {
        xsens = XSlider.value;
        Player.SendMessage("x_sens", xsens);
    }

}
