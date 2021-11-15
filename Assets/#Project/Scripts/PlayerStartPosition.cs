using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject player = LevelsManager.instance.player;
        player.transform.position = transform.position;
        


    }


}
