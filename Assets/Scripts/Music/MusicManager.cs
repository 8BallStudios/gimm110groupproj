using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//How to use:
//Put two audio sources on this gameobject. One should have the gameplay music and the other should have the airlock music.
//Assign these variables.

//Script by Matthew Bridgeman

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    public enum Music {gameplay, airlock, dontchange}
    public Music activeMusic;

    [SerializeField] private AudioSource gameplayMusic;
    [SerializeField] private AudioSource airlockMusic;

    void Start()
    {
        instance = this;

        ChangeMusic(Music.dontchange);
    }

    public void ChangeMusic(Music music = Music.dontchange)
    {
        //Stop all music
        gameplayMusic.Stop();
        airlockMusic.Stop();

        //Change the active music variable. The parameter has a default value of dontchange for instances
        //like when the player starts when we want to just use the variable we already have assigned in the inspector.
        if (music != Music.dontchange) activeMusic = music;

        //Play the correct music
        if (activeMusic == Music.gameplay) gameplayMusic.Play();
        else if (activeMusic == Music.airlock) airlockMusic.Play();

    }
}
