using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorDown : MonoBehaviour
{
    public Animator Animator;
    private void OnTriggerEnter(Collider other)
    {
        Animator.SetBool("Down", true);
        Animator.SetBool("Up", false);
    }
}
