using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollision : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private bool blue;
    private bool red;
    private bool yellow;
    private bool purple;
    private bool orange;
    private bool green;
    private bool finalColor;


    protected void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            //disable le red yellow ou blue après avoir reçu la 2e couleur!!!
            // marche yellow > blue > red (pas le reste)

            case "Blue":
                if (red)
                {
                    spriteRenderer.sprite = spriteArray[4];
                    red = false;
                    purple = true;
                }
                else if (yellow)
                {
                    spriteRenderer.sprite = spriteArray[6];
                    yellow = false;
                    green = true;
                }
                else if (finalColor)
                {
                    blue = false;
                    spriteRenderer.sprite = spriteArray[0];
                }
                else
                {
                    spriteRenderer.sprite = spriteArray[1];
                    blue = true;
                }
                Destroy(collision.gameObject);
                break;
            case "Red":
                if (blue) {
                    spriteRenderer.sprite = spriteArray[4];
                    blue = false;
                    purple = true;
                }
                else if (yellow)
                {
                    spriteRenderer.sprite = spriteArray[5];
                    yellow = false;
                    orange = true;
                }
                else if (green)
                {
                    
                    spriteRenderer.sprite = spriteArray[0];
                }
                else { 
                    spriteRenderer.sprite = spriteArray[2];
                    red = true;
                }
                Destroy(collision.gameObject);
                break;
            case "Yellow":
                if (blue)
                {
                    spriteRenderer.sprite = spriteArray[6];
                    blue = false;
                    green = true;
                }
                else if (red)
                {
                    spriteRenderer.sprite = spriteArray[5];
                    red = false;
                    orange = true;
                }
                else if (purple)
                {
                    yellow = false;
                    spriteRenderer.sprite = spriteArray[0];
                }
                else
                {
                    spriteRenderer.sprite = spriteArray[3];
                    yellow = true;
                }
                Destroy(collision.gameObject);
                break;
        }
    }

    public Sprite newSprite;



}
