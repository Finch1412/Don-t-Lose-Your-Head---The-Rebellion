using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraSwap : MonoBehaviour
{
    //The main controller for placeing the players head down on lamps and then returning them back to the player body.

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
    public GameObject playerbody;



    // Start is called before the first frame update
    void Awake()
    {
        headOn = true;
        playerbody = GameObject.FindGameObjectWithTag("PlayerBody");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(headOn);

        if (!headOn)
        {
            //input for collecting player head from lamp and returning it to head.
            if (Input.GetKey(KeyCode.Q))
            {
                if (lightCamera.GetComponentInParent<LampRange>().inRange)
                {
                    //set the the POV to be from the player body.
                    playerCamera.enabled = true;
                    playerListener.enabled = true;
                    
                    //Disabled the camera on the Lamp collected from.
                    lightCamera.enabled = false;
                    lightListener.enabled = false;
                    headOn = true;
                    source.PlayOneShot(headReturnSFX);
                    
                    //rotates the player body to match the y rotation of the player camera so that the hands always return to the same position within the players POV when head returns to player body.
                    float yRot = playerCamera.transform.eulerAngles.y;
                    playerbody.transform.eulerAngles = new Vector3(playerbody.transform.eulerAngles.x, yRot, playerbody.transform.eulerAngles.z);


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
        
        //Turns the Vignette on and off when the player looks at a lamp and then away from said lamp.
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
                

                //Places the player head on the lamp when while looking at the lamp and pressing E.

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
        //Sets it so the script know the player is no longer looking at a lamp.
        if (other.transform.tag == "LightCamera")
        {
            lookingAtCamera = false;
            headOffUI.SetActive(false);

        }
    }



}
