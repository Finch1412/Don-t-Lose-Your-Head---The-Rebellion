using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject activation;
    private bool switchOn = true;
    [SerializeField] private Animator switchLever;
    [SerializeField] private string anim = "Animation";
    [SerializeField] private Animator otherObj;
    [SerializeField] private string otherAnim = "Animation";

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
        Debug.Log(other);
        if (Input.GetKey(KeyCode.E))
        {
            if (switchOn)
            {
                switchOn = false;
                activation.SetActive(switchOn);

                switchLever.Play(anim, 0, 0.0f);
                otherObj.Play(otherAnim, 0, 0.0f);

            }
            //if (!switchOn)
            //{
            //    switchOn = true;
            //    activation.SetActive(switchOn);
            //}
        }
        
        

    }
}
