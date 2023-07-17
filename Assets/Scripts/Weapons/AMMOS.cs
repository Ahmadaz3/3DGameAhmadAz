using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AMMOS : MonoBehaviour
{
    public TMP_Text ammoText;
    public static int pistolCount=7;

    void Update()
    {
        ammoText.text = "AMMO: " + pistolCount;
    }
}
