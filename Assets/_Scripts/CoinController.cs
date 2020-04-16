//
//  Game Name: AvatarClash
//  Source File Name : CoinController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Coin addition and its movement controlled according to boundries
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float horizontalSpeed = 0.1f;
    public Boundary boundary;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
      _move();
      _checkBounds();
    }

    // move the coins horizontally
    private void _move()
    {
      transform.position -= new Vector3(horizontalSpeed, 0.0f, 0.0f);
    }

    // reset the coins after bounds check
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
      var yCoord = Random.Range(boundary.leftBounds, boundary.rightBounds);
      transform.position = new Vector2(Random.Range(10f, 25f), yCoord);
    }

}
