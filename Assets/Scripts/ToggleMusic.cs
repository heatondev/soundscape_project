using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Valve.VR;

public class ToggleMusic : MonoBehaviour
{
    public AudioMixerSnapshot MusicOn;
    public AudioMixerSnapshot MusicOff;

    public SteamVR_Action_Boolean MusicOnOff;
    public SteamVR_Input_Sources handType;

    public GameObject Music;

    public bool OnOff = true;

    void Start()
    {
        MusicOnOff.AddOnStateDownListener(ButtonPressed, handType);
    }

    private void ButtonPressed(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (OnOff == true)
        {
            OnOff = false;
            MusicOff.TransitionTo(0.5f);
        }
        else if (OnOff == false)
        {
            OnOff = true;
            MusicOn.TransitionTo(0.5f);
        }
    }
}
      

    

