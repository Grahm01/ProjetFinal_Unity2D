using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalAnimation : MonoBehaviour
{

    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (gameObject.tag == "PurplePortal")
        {
            if (animator != null)
            {
                animator.SetBool("purple", true);
            }
        }
        if (gameObject.tag == "OrangePortal")
        {
            if (animator != null)
            {
                animator.SetBool("orange", true);
            }

        }
        if (gameObject.tag == "YellowPortal")
        {
            if (animator != null)
            {
                animator.SetBool("yellow", true);
            }

        }

        if (gameObject.tag == "GreenPortal")
        {
            if (animator != null)
            {
                animator.SetBool("green", true);
            }

        }


    }

}
