using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallWarp : MonoBehaviour
{
    public Transform warpTarget;
    public bool alreadyChange = false;

    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (alreadyChange) return;

        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;
        Debug.Log("warped");
        alreadyChange = true;

    }
    private void LateUpdate()
    {
        alreadyChange = false;
    }
}


//------------------ancien code
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class WallWarp : MonoBehaviour
//{
//    public Transform warpTarget;

//    // Use this for initialization
//    private void OnTriggerEnter2D(Collider2D other)
//    {

//        other.gameObject.transform.position = warpTarget.position;
//        Camera.main.transform.position = warpTarget.position;
//        Debug.Log(warpTarget.position);

//    }
//}