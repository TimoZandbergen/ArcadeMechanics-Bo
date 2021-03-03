using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flaslight : MonoBehaviour
{
    public AudioClip soundOn;
    public AudioClip soundOff;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (light.enabled == false)

            {
                light.enabled == true;
                audio.clip = soundOn;
                audio.Play
        }
            {
            else
            }

            {
                light.enabled == false;
                audio.clip = soundOff;
                audio.Play
            }

        }
    }

}
