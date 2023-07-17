using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAmmos : MonoBehaviour
{

    public AudioSource ammoCollect;

    void OnTriggerEnter(Collider other)
    {
       
            ammoCollect.Play();
            AMMOS.pistolCount += 10;
            this.gameObject.SetActive(false);
        
    }
}
