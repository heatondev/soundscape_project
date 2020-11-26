using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class splash : MonoBehaviour
{
    public AudioSource Splash;

    private void Start()
    {
        Splash = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Splash.Play(0);
    }

}
