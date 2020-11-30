using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BrokenVent : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update

    public void ButtonToggle()
    {
        source.PlayOneShot(clip);
        Debug.Log("Door");
    }
}
