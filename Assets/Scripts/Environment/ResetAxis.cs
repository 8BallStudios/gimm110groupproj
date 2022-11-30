using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAxis : MonoBehaviour
{
    public void Update()
    {
        //DO NOT FUCKING CHANGE THIS OR THE GAME WILL BREAK AND I WILL BREAK YOUR LEGS, EAT YOUR EYEBALLS AND CHOP OFF YOUR TOES.
        //thanks :P
        transform.rotation = Quaternion.identity;
    }

}
