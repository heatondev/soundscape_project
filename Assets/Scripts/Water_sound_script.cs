using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_sound_script : MonoBehaviour
{
    public AudioSource Water;
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.CompareTag("player"))
        {
            Water.Play();
        }
    }
   */
    private void OnTriggerEnter(Collider other)
    {
        Water.Play();
    }
}
