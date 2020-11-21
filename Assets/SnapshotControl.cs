using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotControl : MonoBehaviour
{


    public AudioMixerSnapshot aud1;
    public AudioMixerSnapshot aud2;
    private bool tog;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!tog)
            {
                tog = !tog;
                aud1.TransitionTo(1);
            }
            else
            {
                tog = !tog;
                aud2.TransitionTo(1);
            }
        }

   
    }
}
