using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Die()
    {
        GetComponent<Animator>().SetTrigger("Die");
    }
}
