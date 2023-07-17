using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PistolFire : MonoBehaviour
{
    public GameObject myPistol;
    public bool isFire = false;
    public GameObject Flashing;
    public AudioSource pistolshot;
    public float ToTarget;
    //  public GameObject bigest;
    //  public GameObject smallest;
    // public GameObject player;
    public GameObject enime;
    public Image healthbarSprite;
    public int counter = 0;
    private void Start()
    {
        //  bigest.SetActive(false);
        // smallest.SetActive(false);
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    AMMOS.pistolCount = 5;
        //}
        // if Left Mouse Button Is Clicked 
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFire == false)
            {
                StartCoroutine(Fires());
            }
        }

        healthbarSprite.fillAmount = 1f - (counter / 10f);
        Debug.Log(healthbarSprite.fillAmount);
    }
   
   // int counter2 = 0;
    //int counter1 = 0;
    // bool state = false;
    IEnumerator Fires()
    {
        Debug.Log("Your count is " + counter);
        if (AMMOS.pistolCount <= 0)
        {
            isFire = false;
        }
        else
        {
            isFire = true;
            // ToTarget = PlayerCasting.distanceFromTarget;
            myPistol.GetComponent<Animator>().Play("FirePistol");
            pistolshot.Play();
            Flashing.SetActive(true);
            //if (raycasting.hit.collider.gameObject.tag == "goal")
            //{
            //    Destroy(raycasting.hit.collider.gameObject);
            //}

            yield return new WaitForSeconds(0.03f);
            Flashing.SetActive(false);
            yield return new WaitForSeconds(0.22f);
            myPistol.GetComponent<Animator>().Play("New State");
            if (raycasting.hit.collider != null && raycasting.hit.collider.gameObject.tag == "Box")
            {
                Destroy(raycasting.hit.collider.gameObject);
            }

            //if(raycasting.hit.collider != null && raycasting.hit.collider.gameObject.tag == "head")
            //{
            //    counter += 5;

            //}
            if (raycasting.hit.collider != null && raycasting.hit.collider.gameObject.tag == "ghost")
            {

                counter++;

                if (counter >= 10)
                {
                    enime.GetComponent<Animator>().SetBool("Bool", true);
                    yield return new WaitForSeconds(2f);
                    //  float time = Time.time;
                    raycasting.hit.collider.gameObject.SetActive(false);
                    // raycasting.hit.collider.gameObject.SetActive(false);
                    int currentSceneindex = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(currentSceneindex + 1);
                }
            }
            if (raycasting.hit.collider != null && raycasting.hit.collider.gameObject.tag == "head")
            {
                counter += 5;
                Debug.Log(raycasting.hit.collider.gameObject.name);
                if (counter >= 10)
                {
                    //state = true;
                    enime.GetComponent<Animator>().SetBool("Bool", true);
                      yield return new WaitForSeconds(2f);
                    //  float time = Time.time;
                    raycasting.hit.collider.gameObject.SetActive(false);
                    // raycasting.hit.collider.gameObject.SetActive(false);
                    int currentSceneindex = SceneManager.GetActiveScene().buildIndex;
                    SceneManager.LoadScene(currentSceneindex + 1);
                }
            }



            if (AMMOS.pistolCount > 0)
            {
                AMMOS.pistolCount--;
            }
            else
            {
                AMMOS.pistolCount = 0;
            }

            isFire = false;
        }
    }
}
    



