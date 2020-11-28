using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{

    public AudioSource someSound;
    
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (!someSound.isPlaying)
            {
                someSound.Play();
            }
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            someSound.Stop();
        }
    }



}
