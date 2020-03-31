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
      var yCoord = Random.Range(boundary.leftBounds, boundary.rightBounds);
      transform.position = new Vector2(Random.Range(10f, 25f), yCoord);
    }

}
