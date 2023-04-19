using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpherColider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraSwap.headOn)
        {
            this.gameObject.GetComponent<SphereCollider>().enabled = false;
        }
        else
        {
            this.gameObject.GetComponent<SphereCollider>().enabled = true;
        }
    }
}
