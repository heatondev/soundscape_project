using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DoorMover : MonoBehaviour
{
    public GameObject door;
    public GameObject player;

    public AudioClip open;
    public AudioClip close;

    private Vector3 initransform;
    private Vector3 moveTransform;

    private AudioSource speaker;


    private void Start()
    {
        initransform = door.transform.position;
        moveTransform = initransform - new Vector3(0, 10, 0);
        speaker = this.GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.transform.position = moveTransform;
           
            speaker.PlayOneShot(open);

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.transform.position = initransform;

            speaker.PlayOneShot(close);
        }
    }
}
