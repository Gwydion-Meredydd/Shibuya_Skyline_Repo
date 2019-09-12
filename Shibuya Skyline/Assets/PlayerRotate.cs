using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float RotateSpeed = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float HR = Input.GetAxis("Mouse X") * RotateSpeed;
        float VR = Input.GetAxis("Mouse Y") * RotateSpeed;
        transform.Rotate(Vector3.left, 45 * RotateSpeed * Time.deltaTime * RotateSpeed);
    }
}
