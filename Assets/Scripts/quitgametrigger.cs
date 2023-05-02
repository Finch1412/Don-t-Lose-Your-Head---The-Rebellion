using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quitgametrigger : MonoBehaviour
{
    //Loads back to the menu scene when the playerreached the end of the level. Changed to only trigger while headOn to prevent blindly skipping puzzles without collecting head inbetween.

    private void OnTriggerEnter(Collider other)
    {

        if(other.transform.tag == "Player")
        {
            if (CameraSwap.headOn)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
