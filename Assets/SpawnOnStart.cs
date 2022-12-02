using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnStart : MonoBehaviour
{

    //IF YOU EVEN THINK OF CHANGING THIS SCRIPT YOU CAN SAY GOODBYE TO YOUR TOENAILS
    //in other words, changing this at all will basically break the game :P



    public GameObject toSpawn;
    private GameObject spawned;

    void Start()
    {
        spawned = Instantiate(toSpawn, transform.position, transform.rotation);
        spawned.transform.SetParent(this.transform);
        StartCoroutine("ChangeParent");
    }

    public IEnumerator ChangeParent()
    {
        yield return new WaitForSeconds(3);
        spawned.transform.SetParent(null);
    }
}
