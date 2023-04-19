using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityRotate : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = rb.velocity.x;
        Debug.Log(x);
        if (!CameraSwap.headOn)
        {
            transform.forward = rb.velocity;
               
        }
    }
}
