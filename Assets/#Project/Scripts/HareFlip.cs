using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareFlip : PlayerController
{
    private SpriteRenderer playerSprite;
    //public Sprite[] spriteArray;
    //public Sprite LeftSprite;
    //public Sprite RightSprite;

    private Animator animator;

    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (move.x > 0)
        {           
            
            if (animator != null)
            {
                animator.SetBool("right", true);
                animator.SetBool("left", false);
                unFlip();
            }

        }
        if (move.x < 0)
        {
            
            
            if (animator != null)
            {
                animator.SetBool("right", false);
                animator.SetBool("left", true);               
                Flip();
            }
        }
        if (move.x == 0)
        {
            if (animator != null)
            {
                //Debug.Log("stopped");
                animator.SetBool("right", false);
                animator.SetBool("left", false);
            }
        }
    }

    private void Flip()
    {
        transform.localScale = new Vector3(-0.032f, 0.032f, 1f);
        //playerSprite.sprite = LeftSprite;

    }

    private void unFlip()
    {
        transform.localScale = new Vector3(0.032f, 0.032f, 1f);
        //playerSprite.sprite = RightSprite;


    }
}
