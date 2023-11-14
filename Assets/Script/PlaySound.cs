using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundPlayer;

    public bool playSoundOnAwake = false;
    // Start is called before the first frame update

    public void playThisSoundEffects()
    { 
        soundPlayer.Play();
    }

    private void Awake()
    {


        if (playSoundOnAwake) 
        {
            soundPlayer.Play();
        }
    }
}
