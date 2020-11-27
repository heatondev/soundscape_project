using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class snapshotTransition : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioMixerSnapshot fade;
    public AudioMixerSnapshot original;
    public int time;
    
    void OnCollisionEnter(Collision collision)
    {
        fade.TransitionTo (time);
    }
}
