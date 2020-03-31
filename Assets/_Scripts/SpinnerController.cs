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

    private void _move()
    {
      transform.position -= new Vector3(horizontalSpeed, verticalSpeed, 0.0f);
    }

    private void _checkBounds()
    {
      if(transform.position.y <= boundary.lowerBounds)
      {
        _reset();
      }
    }

    private void _reset()
    {
      verticalSpeed = Random.Range(minimumVerticalSpeed, maximumVerticalSpeed);
      horizontalSpeed = Random.Range(minimumHorizontalSpeed, maximumHorizontalSpeed);
      var xCoord = Random.Range(boundary.leftBounds, boundary.rightBounds);
      transform.position = new Vector2(xCoord, boundary.upperBounds);
      
}
}
