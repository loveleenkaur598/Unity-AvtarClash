//
//  Game Name: AvatarClash
//  Source File Name : LandSpikeController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : LandSpike addition and its movement controlled according to boundries
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSpikeController : MonoBehaviour
{
    public float horizontalSpeed = 0.1f;
    public Boundary boundary;

    Random random = new Random();  
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      _move();
      _checkBounds();
    }

    // move the spikes horizontally
    private void _move()
    {
      transform.position -= new Vector3(horizontalSpeed, 0.0f, 0.0f);
    }

    // reset the spikes after bounds check
    private void _checkBounds()
    {
      if(transform.position.x <= boundary.lowerBounds)
      {
        _reset();
      }
    }

    // reset the Landspikes
    private void _reset()
    {
      var yCoord = Random.Range(boundary.leftBounds, boundary.rightBounds);
      transform.position = new Vector2(boundary.upperBounds, yCoord);
    }
}
