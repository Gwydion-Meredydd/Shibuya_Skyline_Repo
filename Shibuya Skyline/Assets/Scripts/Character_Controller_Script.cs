using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller_Script : MonoBehaviour
{
    public GameObject Head;
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        Head.transform.Rotate(v, h, 0);
        Debug.Log(h);
        Debug.Log(v);

    }
}
