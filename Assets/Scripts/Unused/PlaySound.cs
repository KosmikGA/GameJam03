using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class PlaySound : MonoBehaviour {

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource failSound;
    public bool alreadyPlayed = false;
    void Start()
    {
        failSound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            failSound.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
    }
}
