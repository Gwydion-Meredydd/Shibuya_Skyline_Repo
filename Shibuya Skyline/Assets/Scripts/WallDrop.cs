using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDrop : MonoBehaviour
{
    bool active = true;
    public GameObject Rwall, Lwall;
    private GUIElement meshRenderer;

	void Start ()
    {
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
    }

	void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player" && active == true)
        {
            StartCoroutine(Fading());
        }
        
	}

    IEnumerator Fading()
    {
        Rwall.SetActive(true);
        Lwall.SetActive(true);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 0);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 10);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 10);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 20);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 20);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 30);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 30);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 40);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 40);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 50);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 50);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 60);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 60);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 70);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 70);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 80);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 80);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 90);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 90);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 100);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 100);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 110);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 110);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 120);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 120);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 130);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 130);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 140);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 140);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 150);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 150);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 160);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 160);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 170);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 170);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 180);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 180);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 190);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 190);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 200);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 200);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 210);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 210);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 220);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 220);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 230);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 230);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 240);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 240);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 250);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 250);
        yield return new WaitForSeconds(0.02f);
        Rwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 255);
        Lwall.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 255);
        yield return new WaitForSeconds(0.02f);
        active = false;
    }
}
