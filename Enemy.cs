using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float shotCounter;
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    [SerializeField] GameObject projectile;
    [SerializeField] float projSpeed;

    /*
     * [SerializedField] GameObject deathVFX;
     * [SerializedField] float durationOfExplosion = 1f;
     * private GameSession gS;
     * 
     */

    // Start is called before the first frame update
    void Start()
    {
        shotCounter = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        CountDownAndShot();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Dyin d = other.gameObject.GetComponent<Dyin>();
        processHit(d);
        GetComponent<AudioSource>().Play();
    }

    private void processHit(Dyin d)
    {
        health -= d.getDamage();
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject, 0.3f);
    }

    private void CountDownAndShot()
    {
        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {
            Fire();
            shotCounter = Random.Range(minTime, maxTime);
        }
    }
    private void Fire()
    {
        GameObject newProjectile = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        newProjectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -projSpeed);
    }
}
