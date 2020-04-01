using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera camera;

    public GameController gameController;

    [Header("Sound Effects")]

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

    private void OnTriggerEnter2D(Collider2D other) {
      //Debug.Log("Collision!");
      switch (other.gameObject.tag)
      {
          case "Coin":
          coinSound.Play();
          gameController.Score += 100;
          break;
          case "LandSpike":
          hitSound.Play();
          gameController.Lives -= 1;
          break;
          case "Spinner":
          hitSound.Play();
          gameController.Lives -= 1;
          break;
      }
    }

}
