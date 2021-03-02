using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultKeyScript : PlayerInv
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("This a Hit");
        MainDoorkeySetTrue();
    }
}
