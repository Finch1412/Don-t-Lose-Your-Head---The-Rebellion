using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBody : MonoBehaviour
{
    [SerializeField]
    private SkinnedMeshRenderer mesh;

   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Hides the body of the player while the players head is on but makes it visible when the head it off.
        if (CameraSwap.headOn)
        {
            mesh.enabled = false;
        }

        else 
        {
            mesh.enabled = true;
        }
    }
}
