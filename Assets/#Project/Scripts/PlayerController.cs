using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    protected PlayerControls playerControls;
    public float moveSpeed = 15f;
    public float jumpForce = 15f;

    public bool isGrounded;
    public bool canDoubleJump;

    //private Rigidbody2D theRB;

    private SpriteRenderer spriteRenderer;



    //public Transform GroundCheck;
    //public Transform CeilingCheck;
    [Tooltip("speed")]
    public Vector2 speed2 = Vector2.zero;


    private float speed;
    private Vector3 move;


    private float originalXScale;
    private int direction;



    private void Start()
    {

        // scale relative to parent space
        //transform.localScale = new Vector3(0.1f, 0.1f, 1f);
        originalXScale = transform.localScale.x;

        direction = 1;
    }


    private void Awake()
    {
        playerControls = new PlayerControls();

    }

    private void OnEnable()
    {
        playerControls.Enable();

    }
    private void OnDisable()
    {
        playerControls.Disable();

    }

    private void FixedUpdate()
    {
        //float xSpeed = speed * playerControls.Player.Move;
    }


    protected void Update()
    {
        move = playerControls.Player.Move.ReadValue<Vector2>();
        speed = moveSpeed * Time.deltaTime;
        Move();

        if (isGrounded == true)
        {
            Jump();
            canDoubleJump = true;
            //Debug.Log(speed);

        }
        else if (canDoubleJump && playerControls.Player.Jump.triggered)
        {
            Jump();
            canDoubleJump = false;
            //Debug.Log(speed);
        }

        if (speed2.x < 0)
        {
            Debug.Log("Going Right");
            //Flip();



        }
        else
        {
            Debug.Log("Going Left");
            //Flip();


        }





    }

    private void Flip()
    {

        transform.localScale = new Vector3(-0.1f, 0.1f, 1f);


    }

    void Jump()
    {
        if (playerControls.Player.Jump.triggered)
        {

            //jump = playerControls.Player.Jump.ReadValue<float>();
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            //Debug.Log("jumpee!");



        }



    }

    void Move()
    {
        if (playerControls.Player.Move.enabled)
        {
            transform.position += move * speed;



        }

    }

    private void CharacterDirectionCheck(float xSpeed)
    {
        // If the sign of the character's horizontal speed
        // is different from the sign of the direction they are facing in,
        // then we need to flip the character to face the other direction.
        if (xSpeed * direction < 0.0f)
        {
            // Flip the direction the character is facing in
            direction *= -1;

            // Record the character's current scale
            Vector3 scale = transform.localScale;

            // Set the character's X-scale to be their original scale
            // times the direction they are facing in
            scale.x = originalXScale * direction;

            // Apply the new scale to the character's transform
            transform.localScale = scale;
        }

    }
}
