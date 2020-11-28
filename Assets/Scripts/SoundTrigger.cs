﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    public AudioClip triggerSound;
    AudioSource audioSource;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (triggerSound != null)
        {
            audioSource.PlayOneShot(triggerSound, 0.7f);

        }

    }


}
