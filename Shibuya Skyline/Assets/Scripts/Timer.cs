using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    // Use this for initialization
    public float Win_Timer;

    void Start()
    {
        Timer_Reset();
    }
    IEnumerator Win_Timer_Start()
    {
        yield return new WaitForSecondsRealtime(1);
        Win_Timer = Win_Timer +1;
        Timer_Reset();
    }
    
    public void Timer_Reset()
    {
        StartCoroutine(Win_Timer_Start());
    }
}
