using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;
    public float moveSpeed = 15f;
    public float jumpForce= 15f;

    public bool isGrounded = false;

    //public Transform GroundCheck;
    //public Transform CeilingCheck;


    private float speed;
    private Vector3 move;




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
        Jump();


    }
    //protected void FixedUpdate()
    //{
        
        
    //}

    void Jump()
    {
        if (playerControls.Player.Jump.triggered && isGrounded == true)
        {
            //jump = playerControls.Player.Jump.ReadValue<float>();
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            Debug.Log("jumpee!");
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
