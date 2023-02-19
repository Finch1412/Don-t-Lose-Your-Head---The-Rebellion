using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class VignetteGlow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<PostProcessVolume>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
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
