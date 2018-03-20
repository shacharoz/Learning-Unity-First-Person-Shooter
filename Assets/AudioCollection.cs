﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollection : MonoBehaviour {

    private AudioSource _player;

    public List<AudioClip> AudioSounds;


    public void PlayRandom()
    {
        int selectedClipIndex = Random.Range(0, AudioSounds.Count);
        _player.clip = AudioSounds[selectedClipIndex];
        _player.Play();
    }


	// Use this for initialization
	void Start () {
        _player = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
