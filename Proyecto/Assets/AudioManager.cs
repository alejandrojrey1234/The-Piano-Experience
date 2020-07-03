﻿using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public AudioSource Reproductorsonido;
    // Start is called before the first frame update
   

    // Update is called once per frame
    public void Play(string nombre)
    {
       Sound s = Array.Find(sounds, sound => sound.clip.name == nombre);
        Reproductorsonido.volume = s.volume;
        Reproductorsonido.pitch = s.pitch;
        Reproductorsonido.PlayOneShot(s.clip);
    }
}
