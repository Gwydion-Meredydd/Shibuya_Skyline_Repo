using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

    public Animator animator;

    public void Jump()
    {
        animator.SetBool("Jump", true);
    }
}
