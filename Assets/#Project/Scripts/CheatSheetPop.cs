using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CheatSheetPop : PlayerController
{

    //private PlayerControls playerControls;
    public string popUp;
    private bool popUpOpen = false;
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
    IEnumerator WaitCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

    }
}

//CheatSheet - peutêtre utilisée pour le pop-up menu
//if (playerControls.Player.CheatSheet.triggered)
//{
//    PopUpSystem pop = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<PopUpSystem>();
//    pop.PopUp(popUp);
//    //creer images à faire pop up sur la cheatSheet
//}
