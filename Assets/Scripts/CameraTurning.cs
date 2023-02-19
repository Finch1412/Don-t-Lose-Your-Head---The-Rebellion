using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurning : MonoBehaviour
{
    private float xRotation;
    private float yRotation;
    public GameObject upDown;
    public GameObject leftRight;
    public Camera thisCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = upDown.transform.rotation;
         

        
        


           
    }
}
