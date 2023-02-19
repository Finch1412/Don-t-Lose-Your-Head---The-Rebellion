using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{

    public Camera playerCamera;
    private Camera lightCamera;
    public GameObject lightSource;
    public bool lookingAtCamera = false;
    public bool headOn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(lookingAtCamera);

        if(!headOn)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                playerCamera.enabled = true;
                lightCamera.enabled = false;
                headOn = true;

            }
        }
        
            
    }

    private void OnTriggerStay(Collider other)
    {
        if (headOn)
        {
            if (other.transform.tag == "LightCamera")
            {
                lookingAtCamera = true;
                lightCamera = other.gameObject.GetComponent<GetLightCamera>().GetCamera();


                if (Input.GetKey(KeyCode.E))
                {
                    playerCamera.enabled = false;
                    lightCamera.enabled = true;
                    headOn = false;
                }
            }
        
        

        }
        Debug.Log(other);
    }



}
