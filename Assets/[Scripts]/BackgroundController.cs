/******************
 * BackgroundController.cs
 * Lucas Dunster - 101230948
 * Modified: 10/22/2021
 * 
 * Description:
 *  - Controller for background objects
 *  - on _Move(), moves the background object at a given speed across the screen
 *  - on _CheckBounds(), calls _Reset() on the background object if it goes past the lower boundary
 *  - on _Reset(), resets a background object to the top of the boundary
 * 
 * Version 1.05
 *  - No new changes
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Resets a background object to the right of the boundary
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    // Moves the background object at a given speed across the screen
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    // calls _Reset() on the background object if it goes past the left boundary
    private void _CheckBounds()
    {
        // if the background is further than the left side of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
