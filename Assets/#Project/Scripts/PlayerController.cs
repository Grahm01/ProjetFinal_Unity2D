using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

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

    void Start()
    {
        
        
    }



    private void Update()
    {
        //Vector2 move = playerControls.Player.Move.ReadValue<Vector2>();
        //Debug.Log(move);

        //playerControls.Player.Jump.ReadValue<float>();
        //if (playerControls.Player.Jump.ReadValue<float>() == 1) ;
        if (playerControls.Player.Jump.triggered)
        Debug.Log("Jump!");



    }
}
