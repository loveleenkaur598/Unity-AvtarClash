using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimState
{
    NONE,
    IDLE,
    RUN,
    JUMP
}

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    //public Transform spawnPoint;

    public Camera camera;

    public GameController gameController;

    [Header("Sound Effects")]

    public AudioSource coinSound;
    public AudioSource hitSound;

    [SerializeField]
    public Animator animatorController;

    [SerializeField]
    public Rigidbody2D body;

    [SerializeField]
    public AnimState animation = AnimState.IDLE;

    [SerializeField]
    public float horizontalForce;

    [SerializeField]
    public float verticalForce;

    [SerializeField]
    public float maxHorizontalVelocity;

    [SerializeField]
    public float maxVerticalVelocity;

    private int coinCount = 3;

    public bool buttonClicked = false;


    public Camera MainCamera;
    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        horizontalForce = 0.01f;
        verticalForce = 0.05f;
        maxHorizontalVelocity = 8.0f;
        maxVerticalVelocity = 0.01f;
        //transform.position = spawnPoint.position;

    }

    // Update is called once per frame
    void Update()
    {
        //_move();
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collision!");
        switch (other.gameObject.tag)
        {
            case "Coin":
                coinSound.Play();
                coinCount -= 1;
                Debug.Log(coinCount);
                if (coinCount == 2)
                {
                    Destroy(other.gameObject);
                    gameController.coinNum = 1;
                    gameController._buildCoinList();
                }
                else if (coinCount == 1)
                {
                    Destroy(other.gameObject);
                    gameController.coinNum = 1;
                    gameController._buildCoinList();
                }
                else if (coinCount == 0)
                {
                    Destroy(other.gameObject);
                    gameController.coinNum = 1;
                    gameController._buildCoinList();
                    coinCount = 3;
                }
                gameController.Score += 100;
                break;
                // case "LandSpike":
                // hitSound.Play();
                // gameController.Lives -= 1;
                // break;
                // case "Spinner":
                // hitSound.Play();
                // gameController.Lives -= 1;
                // break;
        }
    }
private void _move()
    {
        Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = new Vector2 (mousePosition.x, -3.40f);
        transform.position = new Vector2(Mathf.Clamp(mousePosition.x, -7.55f, 8.95f), -3.5f);
    }

    
    public void moveRight()
    {


        animatorController.SetInteger("AnimState", 0);
    
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f); 
        body.AddForce(new Vector2(horizontalForce, 0.0f));

        //transform.position = new Vector2(Mathf.Clamp(body.position.x, -7.55f, 8.95f), -3.5f);
        //body.MovePosition(new Vector2(Mathf.Clamp(body.position.y, -7.55f, 8.95f), horizontalForce));

        var xVelocity = Mathf.Clamp(body.velocity.x, 0.0f, maxHorizontalVelocity);
        var yVelocity = body.velocity.y;
        body.velocity = new Vector2(xVelocity, yVelocity);



        //btnClicked();
    }
    public void moveLeft()
    {

        animation = AnimState.RUN;
        animatorController.SetInteger("AnimState", 0);

        transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        body.AddForce(new Vector2(-horizontalForce, 0.0f));

        var xVelocity = Mathf.Clamp(body.velocity.x, -maxHorizontalVelocity, 0.0f);
        var yVelocity = body.velocity.y;
        body.velocity = new Vector2(xVelocity, yVelocity);
    }

    public void jump()
    {
        animation = AnimState.JUMP;
        animatorController.SetInteger("AnimState", 1);
        body.AddForce(new Vector2(0.0f, verticalForce));

        // var xVelocity = body.velocity.x;
        // var yVelocity = Mathf.Clamp(body.velocity.y, 0.0f, maxVerticalVelocity);
        // body.velocity = new Vector2(xVelocity, yVelocity);
    }

}
