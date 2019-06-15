using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TutNav : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent player;

	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Target");
        player = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        player.SetDestination(player.transform.position);
	}
}
