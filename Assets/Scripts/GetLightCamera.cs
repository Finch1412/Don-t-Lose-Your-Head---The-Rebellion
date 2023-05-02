using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLightCamera : MonoBehaviour
{
    [SerializeField]
    private Camera lightCamera;
    [SerializeField]
    private AudioListener lightListener;

    //gets the Camera and audio listener components of the attached camera, this can the be accessed by the CameraSwap script.
    
    public Camera GetCamera()
    {
        return lightCamera;
    }
    public AudioListener GetAudioListener()
    {
        return lightListener;
    }
}
