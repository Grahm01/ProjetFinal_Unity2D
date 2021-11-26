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



    private float speed;
    protected Vector3 move;


    private void Start()
    {
        //playerSprite = GetComponent<SpriteRenderer>();
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
        }







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



    
}
