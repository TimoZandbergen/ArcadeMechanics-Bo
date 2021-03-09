using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFlashlight : MonoBehaviour
{
    public bool isOn = false;
    public GameObject lightSource;

    void Start()
    {
        lightSource.SetActive(false);  
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
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
            
    }
}
