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

    private void _move()
    {
      transform.position -= new Vector3(horizontalSpeed, 0.0f, 0.0f);
    }

    private void _checkBounds()
    {
      if(transform.position.x <= boundary.lowerBounds)
      {
        _reset();
      }
    }

    private void _reset()
    {
      transform.position = new Vector2(boundary.upperBounds,0.0f);
    }
}
