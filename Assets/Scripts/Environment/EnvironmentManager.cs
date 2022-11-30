using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//How to use:
//In the inspector, create all of the environment modifiers. Give them each a name and assign the pieces that should be enabled when activated.
//Later, the cards will call EnablePiece(), passing in the environment modifier name as a parameter.

//Script by Matthew Bridgeman

[Serializable]
public class EnvironmentPiece
{
    public string name;
    public bool enabled;
    public GameObject[] pieces;
}

public class EnvironmentManager : MonoBehaviour
{
    public static EnvironmentManager instance;

    public List<EnvironmentPiece> environmentPieces = new List<EnvironmentPiece>();

    //This is temporary. Eventually, each marker will call EnablePiece() using a different environment modifier
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) EnablePiece("Fire");
        if (Input.GetKeyDown(KeyCode.W)) EnablePiece("ElectricWires");
        if (Input.GetKeyDown(KeyCode.E)) EnablePiece("Turrets");
    }

    public void Start()
    {
        instance = this;

        for (int i = 0; i < environmentPieces.Count; i++)
        {
            environmentPieces[i].enabled = false;
            foreach (GameObject obj in environmentPieces[i].pieces) obj.SetActive(false);
        }
    }

    public void EnablePiece(string pieceName)
    {
        for (int i = 0; i < environmentPieces.Count; i++)
        {
            if (environmentPieces[i].name == pieceName)
            {
                environmentPieces[i].enabled = true;
                foreach (GameObject obj in environmentPieces[i].pieces) obj.SetActive(true);
            }
        }
    }
}
