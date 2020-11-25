using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abance_script : MonoBehaviour
{
    public AudioSource alarm;
    public AudioSource background;
    // private void OnCollisionEnter(Collision collision)
    //{
    // if (collision.gameObject.CompareTag("player"))
    //{
    //  alarm.Stop();
    //   background.Play();
    //}
    //}
    private void OnTriggerEnter(Collider other)
    {
        alarm.Stop();
        background.Play();
    }
}
