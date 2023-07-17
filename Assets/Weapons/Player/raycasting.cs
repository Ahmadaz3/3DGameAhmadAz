using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{
    

  public static RaycastHit hit;
    public static float distanceFromTarget;
    void Update()
    {
     
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            distanceFromTarget = hit.distance;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
          //  Debug.Log("Did Hit");
        }
    }
}
