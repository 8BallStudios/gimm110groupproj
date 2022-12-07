using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//On moving platform in main scene
public class StickyPlatform : MonoBehaviour
{
    //Platform become parent when player collides with it
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    //It doesn't when player gets off
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
