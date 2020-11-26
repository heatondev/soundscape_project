using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicOn : MonoBehaviour
{
    public AudioMixerSnapshot Music;

    private void OnTriggerEnter(Collider other)
    {
        Music.TransitionTo(0.9f);
    }
}