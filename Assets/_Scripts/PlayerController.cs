//
//  Game Name: AvatarClash
//  Source File Name : PlayerController.cs
//  Author’s Name : Dipal Patel (301090880), Loveleen Kaur (301093331) , Bhavya Shah (301076681)
//  Date Last Modified : 13 April 2020
//  Program Description : This is the heart of the game
//
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
    

    public GameController gameController;
    [SerializeField]
    public Transform spawnPoint;

    public Transform playerSpawnPoint;

    [Header("Sound Effects")]

    public AudioSource coinSound;
    public AudioSource hitSound;

    [Header("Physics")]
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

    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        horizontalForce = 0.01f;
        verticalForce = 0.04f;
        maxHorizontalVelocity = 8.0f;
        maxVerticalVelocity = 0.01f;
        isGrounded = false;
        transform.position = spawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.55f, 7.55f) , 
                                transform.position.y, transform.position.z);
    }

    // trigger  coin spikes and spinner collision 
    // perform lives and score count operation
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
                case "LandSpike":
                hitSound.Play();
                gameController.Lives -= 1;
                //transform.position = playerSpawnPoint.transform.position;
                break;
                case "Spinner":
                hitSound.Play();
                gameController.Lives -= 1;
                //transform.position = playerSpawnPoint.transform.position;
                break;
        }
    }
    
    // detect the collision with ground
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
        }    
    }

    // detect the collision with ground
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }
    }

    // move the right left
    public void moveRight()
    {
        animatorController.SetInteger("AnimState", 0);
    
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f); 
        body.AddForce(new Vector2(horizontalForce, 0.0f));

        var xVelocity = Mathf.Clamp(body.velocity.x, 0.0f, maxHorizontalVelocity);
        var yVelocity = body.velocity.y;
        body.velocity = new Vector2(xVelocity, yVelocity);

    }

    // move the player left
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

    // perform jump action
    public void jump()
    {
        if(isGrounded == false)
        {
            return;
        }
        else{
            animation = AnimState.JUMP;
            animatorController.SetInteger("AnimState", 1);
            body.AddForce(new Vector2(0.0f, verticalForce));

            var xVelocity = body.velocity.x;
            var yVelocity = Mathf.Clamp(body.velocity.y, 0.0f, maxVerticalVelocity);
            body.velocity = new Vector2(xVelocity, yVelocity);
            isGrounded = false;
        }
    }

}
