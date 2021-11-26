using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareFlip : PlayerController
{
    public SpriteRenderer playerSprite;
    public Sprite[] spriteArray;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (move.x > 0)
        {
            //Debug.Log("Going Right");
            unFlip();



        }
        if (move.x < 0)
        {
            //Debug.Log("Going Left");
            Flip();


        }

    }

    private void Flip()
    {
        if (spriteArray == null || spriteArray.Length < 2)
        {
            return;
        }
        //Debug.Log(gameObject.name, gameObject);
        transform.localScale = new Vector3(-0.1f, 0.1f, 1f);
        playerSprite.sprite = spriteArray[1];
    }

    private void unFlip()
    {
        if (spriteArray == null || spriteArray.Length < 2)
        {
            return;
        }
        transform.localScale = new Vector3(0.1f, 0.1f, 1f);
        playerSprite.sprite = spriteArray[0];

    }
}
