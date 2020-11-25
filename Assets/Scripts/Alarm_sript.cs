using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm_sript : MonoBehaviour
{
    public AudioSource alarm;
    public AudioSource background;
    //private void OnCollisionEnter(Collision collision)
    // {
    //    if (collision.gameObject.CompareTag("player"))
    //    {
    //        background.Stop();
    //       alarm.Play();
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        background.Stop();
        alarm.Play();
    }
}
