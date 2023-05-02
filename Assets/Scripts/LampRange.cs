using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampRange : MonoBehaviour
{
    public bool inRange = false;
    //public GameObject headOnUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inRange);
    }
    //while this script is enabled on a lamp, it makes sure the player is close enough to the lamp to be able to interact with it.
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            //headOnUI.SetActive(true);
            inRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            //headOnUI.SetActive(false);
            inRange = false;
        }
    }
}
