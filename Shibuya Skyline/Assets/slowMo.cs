using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowMo : MonoBehaviour {

    [Range(0f, 100f)]
    public float slowdownFactor = 0.05f;
    [Range(0f, 100f)]
    public float slowdownLength = 2f;
    

    void Update()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
   
}
