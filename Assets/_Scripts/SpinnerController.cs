//
//  Game Name: AvatarClash
//  Source File Name : SpinnerController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Spinner addition and its movement controlled according to boundries
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerController : MonoBehaviour
{
    public float verticalSpeed;
    public float horizontalSpeed;
    public Boundary boundary;

    [Header("Min / Max Speeds")]
    public float minimumVerticalSpeed;
    public float maximumVerticalSpeed;
    public float minimumHorizontalSpeed;
    public float maximumHorizontalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _reset();
    }

    // Update is called once per frame
    void Update()
    {
        _move();
        _checkBounds();
    }


    // move the spikes vertically
    private void _move()
    {
        transform.position -= new Vector3(horizontalSpeed, verticalSpeed, 0.0f);
    }

    // reset the spinner after bounds check
    private void _checkBounds()
    {
        if (transform.position.y <= boundary.lowerBounds)
        {
            _reset();
        }
    }

    // reset the spikes
    private void _reset()
    {
        verticalSpeed = Random.Range(minimumVerticalSpeed, maximumVerticalSpeed);
        horizontalSpeed = Random.Range(minimumHorizontalSpeed, maximumHorizontalSpeed);
        var xCoord = Random.Range(boundary.leftBounds, boundary.rightBounds);
        transform.position = new Vector2(xCoord, boundary.upperBounds);
    }
}
