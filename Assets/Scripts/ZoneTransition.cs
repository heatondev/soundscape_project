using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ZoneTransition : MonoBehaviour
{
    public AudioMixerSnapshot rightHall;
    public AudioMixerSnapshot mainHub;
    public AudioMixerSnapshot leftHall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "rightHallCollider")
        {
            rightHall.TransitionTo(0.5f);
        }
        if(other.gameObject.tag == "mainHubCollider")
        {
            mainHub.TransitionTo(0.5f);
        }
        if(other.gameObject.tag == "leftHallCollider")
        {
            leftHall.TransitionTo(0.5f);
        }
    }
}
