/******************
 * BulletManager.cs
 * Lucas Dunster - 101230948
 * Modified: 10/22/2021
 * 
 * Description:
 *  - The Bullet Manager creates the bullet pool that the player fires its bullets from
 *  - On Start(), _BuildBulletPool() is called to create the initial bullet pool with a set amount of bullets
 *  - GetBullet() dequeues a bullet from the bullet pool, activates it, and places it at the provided location
 *  - HasBullets() returns whether the current amount of bullets in the pool is greater than 0 or not
 *  - ReturnBullet() deactivates and returns a given bullet to the bullet pool
 * 
 * Version 1.05
 *  - No new changes
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletManager : MonoBehaviour
{
    public BulletFactory bulletFactory;
    public int MaxBullets;

    private Queue<GameObject> m_bulletPool;


    // Start is called before the first frame update
    void Start()
    {
        _BuildBulletPool();
    }

    // creates the initial bullet pool with a set amount of bullets
    private void _BuildBulletPool()
    {
        // create empty Queue structure
        m_bulletPool = new Queue<GameObject>();

        for (int count = 0; count < MaxBullets; count++)
        {
            var tempBullet = bulletFactory.createBullet();
            m_bulletPool.Enqueue(tempBullet);
        }
    }

    // dequeues a bullet from the bullet pool, activates it, and places it at the provided location
    public GameObject GetBullet(Vector3 position)
    {
        var newBullet = m_bulletPool.Dequeue();
        newBullet.SetActive(true);
        newBullet.transform.position = position;
        return newBullet;
    }

    // returns whether the current amount of bullets in the pool is greater than 0 or not
    public bool HasBullets()
    {
        return m_bulletPool.Count > 0;
    }

    // deactivates and returns a given bullet to the bullet pool
    public void ReturnBullet(GameObject returnedBullet)
    {
        returnedBullet.SetActive(false);
        m_bulletPool.Enqueue(returnedBullet);
    }
}
