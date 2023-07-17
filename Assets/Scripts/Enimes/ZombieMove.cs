using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ZombieMove : MonoBehaviour
{
    public GameObject DesPoint;
    NavMeshAgent meshAgent;
    public float ToTarget;
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>(); 
       
    }

    // Update is called once per frame
    void Update()
    {
        meshAgent.SetDestination(DesPoint.transform.position);
    }
}
