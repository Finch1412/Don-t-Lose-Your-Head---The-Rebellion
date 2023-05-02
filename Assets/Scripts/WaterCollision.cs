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
        //Disables the collider of the water doors while the players head is off. The use of the "Water" tag allows for using impassable water in forms of things other than sprinklers.
       if(collision.transform.tag == "Water")
        {
            if (!CameraSwap.headOn)
            {
                collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            }

            
            
        }
        
    }
    
}
