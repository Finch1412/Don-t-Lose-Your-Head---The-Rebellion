using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLightCamera : MonoBehaviour
{
    [SerializeField]
    private Camera lightCamera;
    [SerializeField]
    private AudioListener lightListener;
    
    public Camera GetCamera()
    {
        return lightCamera;
    }
    public AudioListener GetAudioListener()
    {
        return lightListener;
    }
}
