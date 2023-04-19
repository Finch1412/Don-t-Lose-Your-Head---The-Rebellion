using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonLook : MonoBehaviour
{
    [SerializeField] private bool buttonHover = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        buttonHover = true;
    }
    private void OnTriggerExit(Collider other)
    {
        buttonHover = false;
    }
}
