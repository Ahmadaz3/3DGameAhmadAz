using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{

    //The Distance How far we are from we are looking at
    public static float distanceFromTarget;

    public float ToTarget;
 //  public static int count = 8;

    void Update()
    {
        RaycastHit hit;
        // we get the Distance Using RayCast The Ray from transform.position and looking forward and outing the Value to hit
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit))
        {
            // Distance to traget that will equal the hit distance  we outed before
            ToTarget = hit.distance;
            distanceFromTarget = hit.distance;
        }
      //  Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * ToTarget, Color.red, 2f);

    }

}
