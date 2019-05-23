using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Controller : MonoBehaviour {
    public Animator Animator;

    public void Time()
    {
        Animator.SetBool("Time", true);
        StartCoroutine(Reset());
    }
    IEnumerator Reset()
    {
        yield return new WaitForSecondsRealtime(2f);
        Animator.SetBool("Time", false);
    }
}
