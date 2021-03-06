using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;


    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerController>().isGrounded = true;
            //Debug.Log("OnDaGround");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerController>().isGrounded = false;
            //Debug.Log("Nope, I'm not OnDaGround");
        }

    }
}
