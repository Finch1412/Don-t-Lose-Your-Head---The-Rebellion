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
