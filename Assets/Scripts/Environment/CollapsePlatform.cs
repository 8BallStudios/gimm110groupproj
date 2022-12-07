using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//On CollapsingPlatfroms in main scene
public class CollapsePlatform : MonoBehaviour
{
    //Variable game component for physics
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //Starts off with the rb component 
        rb = GetComponent<Rigidbody2D>();
    }

    //Brings in collision elements
    void OnCollisionEnter2D (Collision2D col)
    {   
        //If player is the object to collide
        if (col.gameObject.name.Equals("Player"))
        {
            //Allows function to occur
            Invoke ("DropPlatform", 0.5f);
            //Platform will disappear after drop
            Destroy (gameObject, 2f);
        }
    }

    //Platfrom collapses/drops
    void DropPlatform()
    {
        rb.isKinematic = false;
    }
}
