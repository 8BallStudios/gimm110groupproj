using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 1;
    public static Player instance;

    public void Start()
    {
        instance = this;
    }

    public void Die()
    {
        GetComponent<Animator>().SetTrigger("Die");
        UIManager.instance.Lose();
        StartCoroutine("Pause");
    }

    public IEnumerator Pause()
    {
        yield return new WaitForSeconds(2f);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Trap")) TakeDamage();
    }

    public void IncreaseHealth()
    {
        health++;
    }

    public void TakeDamage()
    {
        health--;
        //particles
        //sfx
        if (health <= 0) Die();
    }
}
