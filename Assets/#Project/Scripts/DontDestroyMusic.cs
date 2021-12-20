using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    
    private void Awake()
    {
        GameObject[] objct = GameObject.FindGameObjectsWithTag("music");
        if (objct.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
}
