using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class snapshotTransition : MonoBehaviour
{
    public AudioSource stumble;
    public AudioSource AudioSource;
    public AudioMixerSnapshot fade;
    public AudioMixerSnapshot original;
    public int time;
    public bool alarmOff=false;
  
  
    void OnCollisionEnter(Collision collision)
    {
        fade.TransitionTo (time);
        if (alarmOff == false)
        { 
            stumble.Play();
            alarmOff = true;
        }
    }
}
