//
//  Game Name: AvatarClash
//  Source File Name : BackgroundController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Controller Background Movement
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    public float horizontalSpeed = 0.05f;
    public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {
      boundary.upperBounds = 10.80f;
      boundary.lowerBounds = -11f;
    }

    // Update is called once per frame
    void Update()
    {
      _move();
      _checkBounds();
    }

    // move the background horizontally
    private void _move()
    {
      transform.position -= new Vector3(horizontalSpeed, 0.0f, 0.0f);
    }

    // reset the background after bounds check
    private void _checkBounds()
    {
      if(transform.position.x <= boundary.lowerBounds)
      {
        _reset();
      }
    }


    // reset the background
    private void _reset()
    {
      transform.position = new Vector2(boundary.upperBounds,0.0f);
    }
}
