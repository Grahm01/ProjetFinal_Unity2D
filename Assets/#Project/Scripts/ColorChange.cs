using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public enum ColorStatus { gray = 0, blue = 1, red = 2, yellow = 3, purple = 4, orange = 5, green = 6 }
    public ColorStatus colorState;

    public bool alreadyChange = false;

    public UnityEvent whenEnter;
    public UnityEvent whenEnterRestart;

    private Animator restartAnimator;

    private void Start()
    {
        colorState = ColorStatus.gray;

        restartAnimator = GameObject.FindGameObjectWithTag("Restart").GetComponent<Animator>();
    }
    private void Update()
    {

    }

    public void ChangeColor(string tag)
    {
        if (alreadyChange) return; //permet de pas changer 2fois la couleur dans la même frame

        switch (tag)
        {
            case "Restart":

                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple || colorState == ColorStatus.blue || colorState == ColorStatus.red || colorState == ColorStatus.yellow || colorState == ColorStatus.gray)
                {
                    Debug.Log("Restart");
                    whenEnterRestart?.Invoke();                    
                    colorState = ColorStatus.gray;
                    restartAnimator.SetBool("open", false);
                }

                break;

            case "Blue":

                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple || colorState == ColorStatus.gray)
                {
                    colorState = ColorStatus.blue;

                    
                    //Debug.Log("Blue tru");

                }
                else if (colorState == ColorStatus.red)
                {
                    colorState = ColorStatus.purple;

                    //Debug.Log("red + blue true");

                }
                else if (colorState == ColorStatus.yellow)
                {
                    colorState = ColorStatus.green;

                    //Debug.Log("yellow + blue true");
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


                    //Debug.Log("red true");
                }
                else if (colorState == ColorStatus.blue)
                {
                    colorState = ColorStatus.purple;

                    //Debug.Log("blue + red true");

                }
                else if (colorState == ColorStatus.yellow)
                {
                    colorState = ColorStatus.orange;

                    //Debug.Log("yellow + red true");
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

                   // Debug.Log("blue + yellow true");

                }
                else if (colorState == ColorStatus.red)
                {
                    colorState = ColorStatus.orange;

                    //Debug.Log("red + yellow true");
                }
                else
                {
                    colorState = ColorStatus.yellow;

                }
                
                break;

            case "Green":
                {
                    if (colorState == ColorStatus.green)
                    {
                        //Debug.Log("NICE Green");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        restartAnimator.SetBool("open", true);
                        //Debug.Log("Wrong color");
                    }

                }
                break;
            case "Orange":
                {
                    if (colorState == ColorStatus.orange)
                    {
                        //Debug.Log("NICE Orange");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        restartAnimator.SetBool("open", true);
                        //Debug.Log("Wrong color");
                    }

                }
                break;
            case "Purple":
                {
                    if (colorState == ColorStatus.purple)
                    {
                        //Debug.Log("NICE Purple");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        restartAnimator.SetBool("open", true);
                        //Debug.Log("Wrong color");
                    }

                }
                break;

            case "BluePortal":
                {
                    if (colorState == ColorStatus.blue)
                    {
                        //Debug.Log("NICE Blue Portal!");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        restartAnimator.SetBool("open", true);
                        //Debug.Log("Wrong color");
                    }

                }
                break;
            case "RedPortal":
                {
                    if (colorState == ColorStatus.red)
                    {
                        //Debug.Log("NICE Red Portal!");
                        whenEnter?.Invoke();
                        //colorState = ColorStatus.gray;

                    }
                    else
                    {
                        restartAnimator.SetBool("open", true);
                        //Debug.Log("Wrong color");
                    }

                }
                break;
            case "YellowPortal":
                {
                    if (colorState == ColorStatus.yellow)
                    {
                        //Debug.Log("NICE Yellow Portal!");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        restartAnimator.SetBool("open", true);
                        //Debug.Log("Wrong color");
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

