using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Alarm : MonoBehaviour
{
    public GameObject sprinkeler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //allows for water doors to be enabled by walking through a trigger box (Can be used for other prefabs)
    private void OnTriggerEnter(Collider other)
    {
        sprinkeler.SetActive(true);
    }
}
