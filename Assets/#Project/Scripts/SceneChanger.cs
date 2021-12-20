using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class SceneChanger : MonoBehaviour
{

    protected PlayerControls playerControls;

    public void Load()
    {
        int index = SceneManager.GetActiveScene().buildIndex; //charge l'index de scène suivante o/ et après on load la scène
        SceneManager.LoadScene(index + 1);
        //Debug.Log("ok I'm in");


    }

    public void reLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void Change(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }


    public void Quit()
    {
        Application.Quit();
    }


}