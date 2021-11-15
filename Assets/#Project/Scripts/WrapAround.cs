using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAround : MonoBehaviour
{

    //
    // Private fields
    //
    private Vector2 screenPos;
    private Vector2 screenExtents;
    private float newX;
    private float newY;
    private readonly Vector3 halfUnit = Vector3.one / 2;
    private SpriteRenderer rend;
    private Camera cam;

    public static WrapAround instance = null;
    public Camera camPrefab;


    //
    // Initialisation
    //
    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this; //instance == moi
            cam = Instantiate(camPrefab);
            DontDestroyOnLoad(cam);

        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
        cam = Camera.main;
    }

    //
    // We check on every physics update
    //
    void FixedUpdate()
    {
        // Viewport position of the object, based on the center
        // of its render bounds.
        screenPos = cam.WorldToViewportPoint(rend.bounds.center);

        // Viewport extents of the object. The extents are just a vector,
        // so we subtract a half-unit vector in order to align it with
        // the viewport coordinate system.
        screenExtents = (cam.WorldToViewportPoint(rend.bounds.extents) - halfUnit);

        // We check if the object's position is outside the boundary.
        // If the boundary is 1 (right or top), we add the extents
        // to the position check. If the boundary is 0 (left or bottom),
        // we subtract.
        if (screenPos.x > 1.0f + screenExtents.x)
        {
            newX = -screenExtents.x;
            newY = screenPos.y;
            SetNewPosition();
        }
        if (screenPos.x < 0 - screenExtents.x)
        {
            newX = 1.0f + screenExtents.x;
            newY = screenPos.y;
            SetNewPosition();
        }
        if (screenPos.y > 1.0f + screenExtents.y)
        {
            newY = -screenExtents.y;
            newX = screenPos.x;
            SetNewPosition();
        }
        if (screenPos.y < 0 - screenExtents.y)
        {
            newY = 1.0f + screenExtents.y;
            newX = screenPos.x;
            SetNewPosition();
        }
    }

    void SetNewPosition()
    {
        // Convert from viewport coordinates back to world.
        // Camera is at z = -10 so we compensate for that here,
        // otherwise the transform z will be at -10 and invisible.
        transform.position = cam.ViewportToWorldPoint(new Vector3(newX, newY, 10));
    }
}