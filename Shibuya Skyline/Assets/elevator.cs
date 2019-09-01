using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public Animator Animator;
    private void OnTriggerEnter(Collider other)
    {
        Animator.SetBool("Up", true);
        Animator.SetBool("Down", false);
    }
}
