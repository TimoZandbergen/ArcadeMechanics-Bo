using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlashlight : MonoBehaviour
{
    public bool isOn = false;
    public GameObject lightSource;
    public AudioSource clickSound;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("F"))
        {
            Debug.Log("click");
            if (isOn == false)
            {
                lightSource.SetActive(true);
                isOn = true;
            }

            else
            {
                lightSource.SetActive(false);
                isOn = false;
            }
        }
        while (isOn == true) ;
            
    }
}
