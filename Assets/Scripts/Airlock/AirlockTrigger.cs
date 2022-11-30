using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//How to use:
//Create an invisible box collider 2d slightly inside the airlock
//Put this script on it
//This object should be a child of the airlock parent (which should have the Airlock script on it)
//Drag the parent just mentioned into the airlockParent variable
//The player should have the tag "Player"

//Script by Matthew Bridgeman

public class AirlockTrigger : MonoBehaviour
{
    public Airlock airlockParent;

    public bool closeDoor;

    //Should the trigger be checking for the player to touch it?
    //We don't want them to activate the trigger multiple times
    public bool checkForTrigger = true;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player") && checkForTrigger)
        {
            checkForTrigger = false;

            if (closeDoor) airlockParent.CloseAirlock();
            else airlockParent.OpenAirlock();
        }
    }
}
