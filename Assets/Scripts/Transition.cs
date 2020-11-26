using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Transition : MonoBehaviour
{
    public AudioMixerSnapshot transitionHallway;

    private void OnTriggerEnter(Collider other)
    {
        transitionHallway.TransitionTo(0.9f);
    }
}
