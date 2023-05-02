using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurning : MonoBehaviour
{
    //Script that makes all lamp child carmeras mimic the rotation of the main player camera.
    public GameObject playerCamera;
    

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = playerCamera.transform.rotation;
    }
}
