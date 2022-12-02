using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePod : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private bool activated = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !activated)
        {
            activated = true;
            GameObject player = collision.gameObject;
            player.GetComponent<SpriteRenderer>().enabled = false;
            anim.SetTrigger("Escape");
        }
    }
}
