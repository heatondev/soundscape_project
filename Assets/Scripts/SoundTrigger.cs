using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource LostTransmission;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            LostTransmission.Play();
        }
    }
}
