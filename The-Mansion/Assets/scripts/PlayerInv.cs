using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{

    protected bool MainDoorKey;
    protected bool BedDoorKey;
    
    private void Start()
    {
        MainDoorKey = false;
        BedDoorKey = false;
    }

    protected void MainDoorkeySetTrue()
    {
        MainDoorKey = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
