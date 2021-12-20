using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

        if (playerControls.Player.Quit.triggered)
        {
            Application.Quit();
            Debug.Log("ESC byebye");
        }
    }





    void Jump()
    {
        if (playerControls.Player.Jump.triggered)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

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
