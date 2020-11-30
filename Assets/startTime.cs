using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTime : MonoBehaviour
{
    AudioSource myAudio;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 15.0f);
    }

    void playAudio()
    {
        myAudio.Play();
    }

}
