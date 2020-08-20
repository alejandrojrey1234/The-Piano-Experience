using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class music_manager : MonoBehaviour
{
    public AudioClip[] list;
    int songNumber;
    AudioSource audio;
    public TMP_Text texto;

    // Start is called before the first frame update
    void Start()
    {

        list = new AudioClip[] {
           (AudioClip)Resources.Load("Musica_numerada/5% Tint - Travis Scott"),
           (AudioClip)Resources.Load("Musica_numerada/Butterfly Effect - Travis Scott"),
           (AudioClip)Resources.Load("Musica_numerada/Giorno's Theme (Piano Cover)"),
           (AudioClip)Resources.Load("Musica_numerada/Santo & Johnny - Sleep walk"),
           (AudioClip)Resources.Load("Musica_numerada/Anakin's Betrayal (Piano Cover)"),
           (AudioClip)Resources.Load("Musica_numerada/dusty"),
           (AudioClip)Resources.Load("Musica_numerada/Endless Mind"),
           (AudioClip)Resources.Load("Musica_numerada/Just Wanted to Tell You")
      };
        songNumber = Random.Range(0, list.Length);
        audio = GetComponent<AudioSource>();
        audio.clip = list[songNumber];
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (audio.isPlaying == false)
        {
            songNumber = Random.Range(0, list.Length); 

            audio.clip = list[songNumber];
            audio.Play();
        }

        texto.text = "Music: " + audio.clip.name;
    }
}
