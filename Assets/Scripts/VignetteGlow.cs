using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class VignetteGlow : MonoBehaviour
{
    //This Script gets the post processing components attatched to the camera(s) and allows the vignette that appears when looking at lamps to be enabaled and disabled by other scripts.
    private LampRange LampRange;

    // Start is called before the first frame update
    void Start()
    {
        //starts the game with the vignette disabled.
        this.GetComponent<PostProcessVolume>().enabled = false;
    }


    public void VignetteOn()
    {
        this.GetComponent<PostProcessVolume>().enabled = true;
    }
    public void VignetteOff()
    {
        this.GetComponent<PostProcessVolume>().enabled = false;
    }

}
