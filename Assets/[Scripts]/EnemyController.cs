/******************
 * EnemyController.cs
 * Lucas Dunster - 101230948
 * Modified: 10/22/2021
 * 
 * Description:
 *  - Controller for the Enemy
 *  - on _Move(), moves the character at a set speed and direction on Update
 *  - on _CheckBounds(), uses the boundary variable and CheckBounds function to limit enemy movement to within the screen
 * 
 * Version 1.06
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Moves the character at a set speed and direction on Update
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    // Uses the boundary variable and CheckBounds function to limit enemy movement to within the screen
    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
