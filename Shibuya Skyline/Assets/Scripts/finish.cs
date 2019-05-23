using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour {
    void Start()
    {
        StartCoroutine(Timer());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    IEnumerator Timer()//button reset scripts
    {
        yield return new WaitForSecondsRealtime(174);
        SceneManager.LoadScene("Menu");
    }

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Menu");
    }
}
