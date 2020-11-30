using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
{

    public AudioSource RobotVoice;
    public Collider DoorCol;

        void OnCollisionEnter(Collision collision)
        {
            RobotVoice.Play();
        }
}
