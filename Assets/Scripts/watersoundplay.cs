using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watersoundplay : MonoBehaviour

{
    public AudioSource watersound;
    // Start is called before the first frame update
    void Start()
    {
        watersound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        watersound.Play();
    }

     void OnCollisionExit(Collision collision)
    {
        watersound.Stop();
    }
}
