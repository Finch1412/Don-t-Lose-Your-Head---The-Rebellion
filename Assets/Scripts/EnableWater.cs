using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableWater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes sure the player cannot walk through water doors while they enabked and the players head is on.
        if (CameraSwap.headOn)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
