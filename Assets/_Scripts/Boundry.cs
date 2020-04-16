//
//  Game Name: AvatarClash
//  Source File Name : BoundryController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : Set the boundries for background, spikes and spinner
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Boundary
{
  public float leftBounds;
  public float rightBounds;
  public float upperBounds;
  public float lowerBounds;
}
