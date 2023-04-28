using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraSwap : MonoBehaviour
{

    public Camera playerCamera;
    public AudioListener playerListener;
    private Camera lightCamera;
    private AudioListener lightListener;
    public GameObject lightSource;
    public bool lookingAtCamera = false;
    static public bool headOn = true;
    [SerializeField]
    private VignetteGlow VignetteGlow;
    public GameObject headOffUI;
    //public GameObject headOnUI;
    public AudioSource source;
    public AudioClip headPlacedSFX;
    public AudioClip headReturnSFX;



    // Start is called before the first frame update
    void Awake()
    {
        headOn = true;
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
                    playerListener.enabled = true;
                    lightCamera.enabled = false;
                    lightListener.enabled = false;
                    headOn = true;
                    source.PlayOneShot(headReturnSFX);


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
                    //headOnUI.SetActive(true);
                }
                else
                {
                    VignetteGlow.VignetteOff();
                    //headOnUI.SetActive(false);
                }
            }
            
        }
        
        if (headOn)
        {
            if (lookingAtCamera == true)
            {
                VignetteGlow.VignetteOn();
            }
            else
            {
                VignetteGlow.VignetteOff();
            }

        }
        
       



    }

    private void OnTriggerStay(Collider other)
    {
        
        if (headOn)
        {
            if (other.transform.tag == "LightCamera")
            {
                headOffUI.SetActive(true);
                lookingAtCamera = true;
                lightCamera = other.gameObject.GetComponent<GetLightCamera>().GetCamera();
                lightListener = other.gameObject.GetComponent<GetLightCamera>().GetAudioListener();
                

                //vignette stuff.

                if (Input.GetKey(KeyCode.E))
                {
                    playerCamera.enabled = false;
                    playerListener.enabled = false;
                    lightCamera.enabled = true;
                    lightListener.enabled = true;
                    source.PlayOneShot(headPlacedSFX); 
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
            headOffUI.SetActive(false);

        }
    }



}
