using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Spawner : MonoBehaviour
{
    //declare GameObjets
    [Range(0f, 20f)]
    public float SpawnDelay;
    public  GameObject enemy, s1, s2, s3,s4,s5,s6,s7,s8,s9,s10;

    void Start()
    {
        //set the spawnpoints
        s1 = GameObject.Find("Spawn1");
        s2 = GameObject.Find("Spawn2");
        s3 = GameObject.Find("Spawn3");
        s4 = GameObject.Find("Spawn4");
        s5 = GameObject.Find("Spawn5");
        s6 = GameObject.Find("Spawn6");
        s7 = GameObject.Find("Spawn7");
        s8 = GameObject.Find("Spawn8");
        s9 = GameObject.Find("Spawn9");
        s10 = GameObject.Find("Spawn10");
        enemy = GameObject.FindGameObjectWithTag("car");
        spawnEnemy();
    }

    public void spawnEnemy()
    {
        //Quaternion.identity
        enemy = GameObject.FindGameObjectWithTag("car");
        Instantiate(enemy, s1.transform.position, s1.transform.rotation);
        Instantiate(enemy, s2.transform.position, s2.transform.rotation);
        Instantiate(enemy, s3.transform.position, s3.transform.rotation);
        Instantiate(enemy, s4.transform.position, s4.transform.rotation);
        Instantiate(enemy, s5.transform.position, s5.transform.rotation);
        Instantiate(enemy, s6.transform.position, s6.transform.rotation);
        Instantiate(enemy, s7.transform.position, s7.transform.rotation);
        Instantiate(enemy, s8.transform.position, s8.transform.rotation);
        Instantiate(enemy, s9.transform.position, s9.transform.rotation);
        Instantiate(enemy, s10.transform.position, s10.transform.rotation);
        Debug.Log("should spawn");
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(SpawnDelay);
        spawnEnemy();
    }
}
