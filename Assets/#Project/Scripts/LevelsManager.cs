using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    public static LevelsManager instance = null;
    public GameObject playerPrefab;
    public GameObject player;

    
    public GameObject cheatSheet;
    public GameObject restart;


    void Start()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this; //instance == moi
            player = Instantiate(playerPrefab);
            restart = Instantiate(restart);
            DontDestroyOnLoad(player);

            
            DontDestroyOnLoad(cheatSheet);
            DontDestroyOnLoad(restart);

        }

        else
        {
            Destroy(gameObject);
        }

    }
}
