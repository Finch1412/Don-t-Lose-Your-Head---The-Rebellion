using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.transform.tag == "Water")
        {
            if (!CameraSwap.headOn)
            {
                collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            }

            
            
        }
        
    }
    
}
