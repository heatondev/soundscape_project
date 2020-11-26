using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scare : MonoBehaviour
{
  
    
    public AudioSource ScareNoise;

    private void Start()
    {
       
        ScareNoise = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
       
        ScareNoise.Play(0);
    }

}

