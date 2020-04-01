using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

    public AudioSource coinSound;
    public AudioSource hitSound;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _move();
    }

    private void _move()
    {
      Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
      //transform.position = new Vector2 (mousePosition.x, -3.40f);
      transform.position = new Vector2 (Mathf.Clamp(mousePosition.x, -7.55f, 8.95f), -3.5f);
    }

    // void OnCollisionEnter2D(Collision2D other) 
    // {
      
    // }

    private void OnTriggerEnter2D(Collider2D other) {
      //Debug.Log("Collision!");
      switch (other.gameObject.tag)
      {
          case "Coin":
          coinSound.Play();
          break;
          case "LandSpike":
          hitSound.Play();
          break;
          case "Spinner":
          hitSound.Play();
          break;
      }
    }

}
