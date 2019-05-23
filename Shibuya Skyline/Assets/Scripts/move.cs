using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    Rigidbody m_Rigidbody;
    [Range(0f, 100f)]
    public float m_Speed;
    [Range(0f, 100f)]
    public float Death_Time;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(Death_Timer()); 

    }

    public void Update()
    {
        //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
        m_Rigidbody.velocity = transform.right * m_Speed;
    }
    IEnumerator Death_Timer()
    {
            yield return new WaitForSecondsRealtime(Death_Time);
            Destroy(gameObject);
    }
}