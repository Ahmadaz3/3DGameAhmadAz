 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public float theDistance;
    public TMP_Text actionText;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public AudioSource openDoor;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 3)
        {
            Debug.Log("Distance Less Than");
            // leftDoor.SetActive(false);
            actionText.text = "Press E";
            if (Input.GetButtonDown("Action"))
            {
                openDoor.Play();
                this.GetComponent<BoxCollider>().enabled = false;
                actionText.text = "";
                leftDoor.GetComponent<Animator>().Play("LeftDoor");
                rightDoor.GetComponent<Animator>().Play("RightDoor");
                actionText.text = "";
            }
        }

    }

    void OnMouseExit()
    {
        actionText.text = "";
    }
}
