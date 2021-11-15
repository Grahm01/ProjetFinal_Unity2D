using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ColorCollision : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public enum ColorStatus {gray=0,blue =1, red=2,  yellow=3, purple=4, orange=5, green=6}
    public ColorStatus colorState = ColorStatus.gray;

    public bool alreadyChange = false;

    public UnityEvent whenEnter;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (alreadyChange) return; //permet de pas changer 2fois la couleur dans la même frame

        switch (collision.tag)
        {

            case "Blue":

                if (colorState==ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple)
                {
                    colorState = ColorStatus.blue;
  
                }
                else if (colorState== ColorStatus.red)
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
                Destroy(collision.gameObject);
                break;

            case "Red":
                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple)
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
                Destroy(collision.gameObject);
                break;

            case "Yellow":
                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple)
                {
                    colorState = ColorStatus.yellow;
                    
                }
                else if (colorState == ColorStatus.blue)
                {
                    colorState = ColorStatus.green;
                    
                    //Debug.Log("blue + yellow true");

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
                Destroy(collision.gameObject);
                break;

            case "Green":
                {
                    if (colorState == ColorStatus.green)
                    {
                        Debug.Log("NICE Green");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        Debug.Log("Wrong color");
                    }

                }
                break;
            case "Orange":
                {
                    if (colorState == ColorStatus.orange)
                    {
                        Debug.Log("NICE Orange");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        Debug.Log("Wrong color");
                    }

                }
                break;
            case "Purple":
                {
                    if (colorState == ColorStatus.purple)
                    {
                        Debug.Log("NICE Purple");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        Debug.Log("Wrong color");
                    }

                }
                break;

            case "BluePortal":
                {
                    if (colorState == ColorStatus.blue)
                    {
                        Debug.Log("NICE Blue Portal!");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        Debug.Log("Wrong color");
                    }

                }
                break;
            case "RedPortal":
                {
                    if (colorState == ColorStatus.red)
                    {
                        Debug.Log("NICE Red Portal!");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        Debug.Log("Wrong color");
                    }

                }
                break;
            case "YellowPortal":
                {
                    if (colorState == ColorStatus.yellow)
                    {
                        Debug.Log("NICE Yellow Portal!");
                        whenEnter?.Invoke();
                        colorState = ColorStatus.gray;

                    }
                    else
                    {
                        Debug.Log("Wrong color");
                    }

                }
                Destroy(collision.gameObject);
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

//---------- ancien code

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ColorCollision : MonoBehaviour
//{
//    public SpriteRenderer spriteRenderer;
//    public Sprite[] spriteArray;
//    public enum ColorStatus { gray = 0, red = 2, yellow = 3, purple = 4, orange = 5, green = 6 }
//    public ColorStatus colorState = ColorStatus.gray;
//    private bool blue;
//    private bool red;
//    private bool yellow;
//    private bool purple;
//    private bool orange;
//    private bool green;
//    private bool finalColor;


//    protected void OnTriggerEnter2D(Collider2D collision)
//    {
//        switch (collision.tag)
//        {
//            //disable le red yellow ou blue après avoir reçu la 2e couleur!!!
//            // marche yellow > blue > red (pas le reste)

//            case "Blue":
//                //switch (colorState)
//                //{

//                //}
//                if (colorState == ColorStatus.orange || colorState == ColorStatus.green || colorState == ColorStatus.purple)
//                {

//                    colorState = ColorStatus.gray;
//                }
//                else if (red)
//                {
//                    spriteRenderer.sprite = spriteArray[4];
//                    purple = true;
//                    finalColor = true;
//                    red = false;
//                }
//                else if (yellow)
//                {
//                    spriteRenderer.sprite = spriteArray[6];
//                    green = true;
//                    finalColor = true;
//                    Debug.Log("yellow + blue true");
//                }
//                else
//                {
//                    spriteRenderer.sprite = spriteArray[1];
//                    blue = true;
//                }
//                Destroy(collision.gameObject);
//                break;

//            case "Red":
//                if (finalColor)
//                {
//                    spriteRenderer.sprite = spriteArray[0];
//                    finalColor = false;
//                    blue = false;
//                    red = false;
//                    yellow = false;
//                }
//                else if (blue)
//                {
//                    spriteRenderer.sprite = spriteArray[4];
//                    purple = true;
//                    finalColor = true;
//                }
//                else if (yellow)
//                {
//                    spriteRenderer.sprite = spriteArray[5];
//                    orange = true;
//                    finalColor = true;
//                    Debug.Log("yellow + red true");
//                }
//                else
//                {
//                    spriteRenderer.sprite = spriteArray[2];
//                    red = true;
//                    Debug.Log("red true");
//                }
//                Destroy(collision.gameObject);
//                break;

//            case "Yellow":
//                if (finalColor)
//                {
//                    spriteRenderer.sprite = spriteArray[0];
//                    finalColor = false;
//                    blue = false;
//                    red = false;
//                    yellow = false;
//                }
//                else if (blue)
//                {
//                    spriteRenderer.sprite = spriteArray[6];
//                    green = true;
//                    finalColor = true;
//                }
//                else if (red)
//                {
//                    spriteRenderer.sprite = spriteArray[5];
//                    orange = true;
//                    finalColor = true;
//                }
//                else
//                {
//                    yellow = true;
//                    spriteRenderer.sprite = spriteArray[3];
//                    Debug.Log("yellow true");
//                }
//                //spriteRenderer.sprite = spriteArray[(int)colorState];
//                Destroy(collision.gameObject);
//                break;
//        }
//    }





//}