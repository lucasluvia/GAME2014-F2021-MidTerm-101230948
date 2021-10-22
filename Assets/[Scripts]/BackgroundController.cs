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
 * Version 1.01
 *  - No changes from template.
 ******************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Resets a background object to the top of the boundary
    private void _Reset()
    {
        transform.position = new Vector3(0.0f, verticalBoundary);
    }

    // Moves the background object at a given speed across the screen
    private void _Move()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
    }

    // calls _Reset() on the background object if it goes past the lower boundary
    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.y <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
