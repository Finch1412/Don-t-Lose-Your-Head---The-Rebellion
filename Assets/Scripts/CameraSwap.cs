using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraSwap : MonoBehaviour
{

    public Camera playerCamera;
    private Camera lightCamera;
    public GameObject lightSource;
    public bool lookingAtCamera = false;
    static public bool headOn = true;
    [SerializeField]
    private VignetteGlow VignetteGlow;


    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(headOn);

        if (!headOn)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                if (lightCamera.GetComponentInParent<LampRange>().inRange)
                {
                    playerCamera.enabled = true;
                    lightCamera.enabled = false;
                    headOn = true;


                }


            }
        }

        //Enables the LampRange Script of the current possessed light source
        if (lightCamera)
        {
            if (lightCamera.enabled == true)
            {
                lightCamera.GetComponentInParent<LampRange>().enabled = true;
            }
            else
            {
                lightCamera.GetComponentInParent<LampRange>().enabled = false;
            }
        }
        

        //turns vignette on and off when in range.
        if (!headOn)
        {
            if (lightCamera)
            {
                if ((lightCamera.GetComponentInParent<LampRange>().inRange))
                {
                    VignetteGlow.VignetteOn();
                }
                else
                {
                    VignetteGlow.VignetteOff();
                }
            }
            
        }
        

        if (lookingAtCamera == true)
        {
            VignetteGlow.VignetteOn();
        }
        else
        {
            VignetteGlow.VignetteOff();
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
                

                //vignette stuff.

                if (Input.GetKey(KeyCode.E))
                {
                    playerCamera.enabled = false;
                    lightCamera.enabled = true;
                    headOn = false;
                }
            }



        }
        //Debug.Log(other);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "LightCamera")
        {
            lookingAtCamera = false;
            
        }
    }



}
