/*
 Mid Term Test
 By: Siying Li
 Student ID: 301054781
 Last Modified by: Siying Li
 2019-10-19
 Description: Island COntroller for level 1
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class IslandController : MonoBehaviour
{
    public float verticalSpeed = 0.05f;


    public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    /// <summary>
    /// This method moves the ocean down the screen by verticalSpeed
    /// </summary>
    void Move()
    {
        Vector2 newPosition = new Vector2(0.0f, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    /// <summary>
    /// This method resets the ocean to the resetPosition
    /// </summary>
    void Reset()
    {
        float randomXPosition = Random.Range(boundary.Left, boundary.Right);
        transform.position = new Vector2(randomXPosition, boundary.Top);
    }

    /// <summary>
    /// This method checks if the ocean reaches the lower boundary
    /// and then it Resets it
    /// </summary>
    void CheckBounds()
    {
        if (transform.position.y <= boundary.Bottom)
        {
            Reset();
        }
    }
}
