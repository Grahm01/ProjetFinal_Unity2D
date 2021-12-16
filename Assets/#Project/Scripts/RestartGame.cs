using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RestartGame : MonoBehaviour
{

    public UnityEvent whenEnter;


    protected void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Restart!");
            whenEnter?.Invoke();
        }
    }
}
