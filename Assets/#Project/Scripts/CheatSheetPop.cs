using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CheatSheetPop : MonoBehaviour
{

    //private PlayerControls playerControls;
    public string popUp;
    private bool popUpOpen = false;

    protected PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();

    }

    private void OnEnable()
    {
        playerControls.Enable();

    }
    private void OnDisable()
    {
        playerControls.Disable();

    }

    void Start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (playerControls.Player.CheatSheet.triggered)
        {
            if (popUpOpen == true)
            {
                PopUpSystem close = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
                close.ClosePopUp(popUp);


                Debug.Log("Closed");
                popUpOpen = false; 
            }


            else 
            {
                PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
                pop.PopUp(popUp);
                Debug.Log("Open");

                //creer images à faire pop up sur la cheatSheet
                //WaitCoroutine();
                popUpOpen = true;
            }

            
        }

    }

}
