using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLightCamera : MonoBehaviour
{
    [SerializeField]
    private Camera lightCamera;
    
    public Camera GetCamera()
    {
        return lightCamera; 
    }


}
