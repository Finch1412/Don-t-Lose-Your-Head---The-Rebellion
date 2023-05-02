using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorSound : MonoBehaviour
{
    public AudioClip errorSound;
    public AudioSource errorSource;  
    [SerializeField]
    private bool canBePressed;
    // Start is called before the first frame update
    void Start()
    {
        canBePressed = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        //Makes an error sound when the player interacts with a menu lemp that currently lacks funtionality.
        if (canBePressed)
        {
            if (Input.GetKey(KeyCode.E))
            {
                errorSource.PlayOneShot(errorSound);
                canBePressed = false;
                Invoke("ErrorPress", 0.5f);
            }

        }

    }
    //This function is invoked in the funtion above with a delay to only allow the button to make the noise every 0.5 seconds.
    public void ErrorPress()
    {
        canBePressed = true;
    }

    //IEnumerator ButtonPress(float delay)
    //{
    //    errorSource.PlayOneShot(errorSound);
    //    yield return new WaitForSeconds(delay);
    //}
}

