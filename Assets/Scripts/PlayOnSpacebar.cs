using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSpacebar : MonoBehaviour
{
    public AudioSource someSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            someSound.Play();
        }
    }
}
