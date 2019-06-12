using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstAppear : MonoBehaviour
{
    bool active = true;
    public GameObject oBst;
    private GUIElement meshRenderer;

	void Start ()
    {
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 0);
	}
	
    void OnTriggerEnter(Collider other)
    {
		if(other.tag == "Player" && active == true)
        {
            StartCoroutine(Fading());
        }
	}

    IEnumerator Fading()
    {
        oBst.SetActive(true);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 0);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 10);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 20);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 30);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 40);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 50);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 60);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 70);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 80);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 90);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 100);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 110);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 120);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 130);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 140);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 150);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 160);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 170);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 180);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 190);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 200);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 210);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 220);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 230);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 240);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 250);
        yield return new WaitForSeconds(0.02f);
        oBst.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 255);
        active = false;
    }
}
