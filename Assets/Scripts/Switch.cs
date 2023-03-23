using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject activation;
    private bool switchOn = true;
    public float time = 2f;
    public float timeScore = 2f;
    [SerializeField] private Animator switchLever;
    [SerializeField] private string animation = "Animation";

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
        if (Input.GetKey(KeyCode.E))
        {
            if (switchOn)
            {
                switchOn = false;
                activation.SetActive(switchOn);

                switchLever.Play(animation, 0, 0.0f);
                
            }
            //if (!switchOn)
            //{
            //    switchOn = true;
            //    activation.SetActive(switchOn);
            //}
        }
        
        

    }
}
