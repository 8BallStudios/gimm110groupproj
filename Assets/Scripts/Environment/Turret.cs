using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float timeBetweenShots;
    public float currentCountdown;

    public GameObject bullet;
    public Transform spawnPos;
    public float bulletSpeed = 1;

    void Update()
    {
        currentCountdown -= Time.deltaTime;

        if (currentCountdown <= 0)
        {
            Shoot();
            currentCountdown = timeBetweenShots;
        }
    }

    public void Shoot()
    {
        GameObject createdBullet = Instantiate(bullet, spawnPos.position, Quaternion.identity);
        createdBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletSpeed, 0), ForceMode2D.Impulse);
    }
}
