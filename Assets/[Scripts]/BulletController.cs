/******************
 * BulletController.cs
 * Lucas Dunster - 101230948
 * Modified: 10/22/2021
 * 
 * Description:
 *  - Controller for the Bullet
 *  - on _Move(), moves all bullet objects at a given speed in a given direction
 *  - on _CheckBounds(), Checks the bullets location, and will return it to the bullet pool if it goes beyond the top boundary
 *  - uses OnTriggerEnter2D() to watch for the bullet to enter a trigger, which returns the bullet to the bullet pool
 * 
 * Version 1.03
 *  - No new changes
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Moves all bullet objects at a given speed in a given direction
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
    }

    // Checks the bullets location, and will return it to the bullet pool if it goes beyond the top boundary
    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    // Watches for the bullet to enter a trigger, which returns the bullet to the bullet pool
    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
