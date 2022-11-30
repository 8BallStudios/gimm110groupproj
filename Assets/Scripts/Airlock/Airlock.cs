using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//How to use:
//Place on the airlock parent gameobject, two of its children should be the doors. 
//The doors should have animators on them, with animation triggers called OpenDoor and CloseDoor
//There should be a child with the AirlockTrigger script on it. Make sure to follow the instructions in there as well.
//There should be two AudioSource components on this. Neither should play on awake. Assign them in the closeDoorSound and openDoorSound variables.

//Script by Matthew Bridgeman


public class Airlock : MonoBehaviour
{
    [Tooltip("The door the player enters the airlock from.")]
    [SerializeField] private GameObject doorBehindPlayer;

    [Tooltip("The door the player exits the airlock through.")]
    [SerializeField] private GameObject doorAheadPlayer;

    [SerializeField] private AudioSource closeDoorSound;
    [SerializeField] private AudioSource openDoorSound;

    //Called by trigger slightly inside airlock
    public void CloseAirlock()
    {
        //Pause the timer
        Timer.instance.PauseTimer();

        //Close the door behind the player
        doorBehindPlayer.GetComponent<Animator>().SetTrigger("CloseDoor");

        //SFX
        closeDoorSound.Play();

        //Play gameplay music
        MusicManager.instance.ChangeMusic(MusicManager.Music.airlock);

        //Allow the scanning of cards
    }

    //Button press?
    public void OpenAirlock()
    {
        //Function that opens airlock door ahead of player. Need to figure out where this is called
        Timer.instance.StartTimer();

        //Opens the door ahead of the player
        doorAheadPlayer.GetComponent<Animator>().SetTrigger("OpenDoor");

        //SFX
        openDoorSound.Play();

        //Play gameplay music
        MusicManager.instance.ChangeMusic(MusicManager.Music.gameplay);
    }
}
