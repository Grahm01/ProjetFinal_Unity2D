using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContinuousScreen : MonoBehaviour
{

    private float AbsScaleX;
    private float ColliderSizeX;
    private float WorldWidth;
    private float WorldHeight;
    //public Camera MainCamera;
    //private Vector2 screenBounds;
    private void Start()
    {
        WorldWidth = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height)).x;
        WorldHeight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height)).y;
    }
    private void Awake()
    {
        //screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        //currentScale of our transform
        AbsScaleX = Mathf.Abs(transform.localScale.x);

        //size of collider, more important thant the sprite
        ColliderSizeX = GetComponentInChildren<BoxCollider2D>().size.x;


    }

    private void Update()
    {
        //if we reach too far we tp on the opposite end
        if(transform.position.x < (- WorldWidth - (ColliderSizeX / 2 * AbsScaleX))) //leave left side of screen
        {
            transform.position = new Vector3(transform.position.x + WorldWidth * 2, transform.position.y);
            Debug.Log("B");
        }

        if (transform.position.x > (- WorldWidth - (ColliderSizeX / 2 * AbsScaleX))) //leave right side of screen
        {
            transform.position = new Vector3(transform.position.x + WorldWidth * 2, transform.position.y);
            Debug.Log(transform.position);
        }
    }

}