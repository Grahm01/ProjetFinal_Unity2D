using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public enum ColorStatus { gray = 0, blue = 1, red = 2, yellow = 3, purple = 4, orange = 5, green = 6 }
    public ColorStatus colorState;

    public bool alreadyChange = false;

    public UnityEvent whenEnter;

    protected PlayerControls playerControls;



    private void Start()
    {
        DefaultColor();

        //restartAnimator = GameObject.FindGameObjectWithTag("Restart").GetComponent<Animator>();

    }

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

    public void Update()
    {
        if (playerControls.Player.Restart.triggered)
        {
            Debug.Log("OK Restart");
            Restart();
            DefaultColor();
        }

    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }
    public void DefaultColor()
    {
        colorState = ColorStatus.gray;
        spriteRenderer.sprite = spriteArray[0];

    }




    public void ChangeColor(string tag)
    {
        if (alreadyChange) return; //permet de pas changer 2fois la couleur dans la même frame

        switch (tag)
        {

            case "Blue":

                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple || colorState == ColorStatus.gray)
                {
                    colorState = ColorStatus.blue;

                }
                else if (colorState == ColorStatus.red)
                {
                    colorState = ColorStatus.purple;

                }
                else if (colorState == ColorStatus.yellow)
                {
                    colorState = ColorStatus.green;
                }
                else
                {
                    colorState = ColorStatus.blue;
                }
                
                break;

            case "Red":
                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple || colorState == ColorStatus.gray)
                {
                    colorState = ColorStatus.red;

                }
                else if (colorState == ColorStatus.blue)
                {
                    colorState = ColorStatus.purple;

                }
                else if (colorState == ColorStatus.yellow)
                {
                    colorState = ColorStatus.orange;
                }
                else
                {
                    colorState = ColorStatus.red;
                }
                
                break;

            case "Yellow":
                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple || colorState == ColorStatus.gray)
                {
                    colorState = ColorStatus.yellow;


                }
                else if (colorState == ColorStatus.blue)
                {
                    colorState = ColorStatus.green;


                }
                else if (colorState == ColorStatus.red)
                {
                    colorState = ColorStatus.orange;

                }
                else
                {
                    colorState = ColorStatus.yellow;

                }
                
                break;
            case "Purple":
                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple || colorState == ColorStatus.gray || colorState == ColorStatus.blue || colorState == ColorStatus.red)
                {
                    colorState = ColorStatus.purple;
                }

                break;

            case "GreenPortal":
                {
                    if (colorState == ColorStatus.green)
                    {
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }

                }
                break;
            case "OrangePortal":
                {
                    if (colorState == ColorStatus.orange)
                    {
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }


                }
                break;
            case "PurplePortal":
                {
                    if (colorState == ColorStatus.purple)
                    {

                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }

                }
                break;

            case "BluePortal":
                {
                    if (colorState == ColorStatus.blue)
                    {
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }


                }
                break;
            case "RedPortal":
                {
                    if (colorState == ColorStatus.red)
                    {

                        whenEnter?.Invoke();
                    }


                }
                break;
            case "YellowPortal":
                {
                    if (colorState == ColorStatus.yellow)
                    {
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }

                }
                break;


        }

        alreadyChange = true;
        spriteRenderer.sprite = spriteArray[(int)colorState];
    }

    private void LateUpdate()
    {
        alreadyChange = false;
    }

}

