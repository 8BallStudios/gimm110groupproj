using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePod : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private ParticleSystem particles;
    private bool activated = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !activated)
        {
            activated = true;
            GameObject player = collision.gameObject;
            player.GetComponent<SpriteRenderer>().enabled = false;
            anim.SetTrigger("Escape");
            particles.Play();

            StartCoroutine("UIUpdate");
        }
    }

    private IEnumerator UIUpdate()
    {
        yield return new WaitForSeconds(7.5f);
        UIManager.instance.Win();
    }
}
