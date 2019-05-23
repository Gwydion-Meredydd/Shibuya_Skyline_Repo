using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    public Animator Animator;
    public GameObject Loose;
    public void Death_Cam()
    {
        Animator.SetBool("Death", true);
        Loose.SetActive(true);
    }
}
