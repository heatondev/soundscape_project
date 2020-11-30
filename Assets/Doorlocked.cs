using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Doorlocked : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(clip);
        Debug.Log("door locked");
    }
}
