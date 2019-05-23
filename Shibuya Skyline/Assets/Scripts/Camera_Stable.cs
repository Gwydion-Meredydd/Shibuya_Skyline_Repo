using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Stable : MonoBehaviour
{

    public Transform target;
    public float moveSpeed = 1;
    public float rotateSpeed = 90;
    private Transform myTransform;

     void Start()
      {
         transform.position = target.position;
         transform.rotation = target.rotation;
         myTransform = transform;
      }

       void Update()
        {
            myTransform.position = Vector3.MoveTowards(myTransform.position, target.position, moveSpeed * Time.deltaTime);
            myTransform.rotation = Quaternion.RotateTowards(myTransform.rotation, target.rotation, rotateSpeed * Time.deltaTime);
        }

}
