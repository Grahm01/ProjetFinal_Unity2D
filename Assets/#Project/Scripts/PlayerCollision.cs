using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ColorChange colorChangeScript;

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        colorChangeScript.ChangeColor(other.tag);

        if (other.tag == "Blue" || other.tag == "Red" || other.tag == "Yellow" || other.tag == "Purple" || other.tag == "Orange" || other.tag == "Green")
        {
            Destroy(other.gameObject);
        }
    }
}
