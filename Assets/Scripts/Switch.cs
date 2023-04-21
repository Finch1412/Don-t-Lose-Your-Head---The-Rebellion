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
    public AudioSource source;
    public AudioClip switchClip;
    public AudioSource othersource;
    public AudioClip otherClip;

    // Start is called before the first frame update
    void Start()
    {
        source = this.GetComponent<AudioSource>();
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
                source.PlayOneShot(switchClip);
                
                switchLever.Play(anim, 0, 0.0f);
                activation.SetActive(false);
                otherObj.Play(otherAnim, 0, 0.0f);
                othersource.PlayOneShot(otherClip);



            }
            //if (!switchOn)
            //{
            //    switchOn = true;
            //    activation.SetActive(switchOn);
            //}
        }
        
        

    }
}
