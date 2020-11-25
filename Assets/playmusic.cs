using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmusic : MonoBehaviour
{
   public AudioSource music;
    public void playsong()
    {
        music.Play();
    }
}
