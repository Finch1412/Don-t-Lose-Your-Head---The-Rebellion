using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorSound : MonoBehaviour
{
    public AudioClip errorSound;
    public AudioSource errorSource;   
    public bool canBePressed;
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

