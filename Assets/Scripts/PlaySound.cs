﻿using System.Collections;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
    }
}
