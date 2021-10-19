using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement2D : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        //Vector3 movement = new Vector3(UnityEngine.Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;
    }
}
