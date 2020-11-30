using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollisionPlayback : MonoBehaviour
{
    public AudioSource doorAudio;
    //public Collider myCollider;

    private void OnCollisionEnter(Collision collision)
    {
        doorAudio.Play();
    }
}
