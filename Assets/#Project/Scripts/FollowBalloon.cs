using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//A remodifier pour les ballons de suivre le joueur - dans le raycast s'arrêter

public class MonsterAI : MonoBehaviour
{
    ////temporary
    //public float agroRange;
    //Animator animator;
    //[SerializeField]
    //float deathRange;
    //public float hitRange;
    //public float moveSpeed;
    ////GameObject notice;

    //[SerializeField]
    //GameObject player; //keep track of the player
    //Rigidbody2D rb2d; //il faut pouvoir accéder au rigidBody
    //SpriteRenderer spriteRenderer;
    ////public UnityEvent whenTouchPlayer;

    //void Start()
    //{
    //    rb2d = GetComponent<Rigidbody2D>();
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    spriteRenderer = GetComponent<SpriteRenderer>();
    //    animator = GetComponent<Animator>();
    //}

    //void Update()
    //{

    //    float distToPlayer = Vector2.Distance(transform.position, player.transform.position);

    //    #region monstre se déplace à gauche ou à droite


    //    if (distToPlayer < agroRange)
    //    {
    //        ChasePlayer();
    //    }
    //    else
    //    {
    //        StopChasingPlayer();
    //    }

    //}
    //void ChasePlayer()
    //{
    //    //si le monstre est à gauche, il se retourne et bouge
    //    if (transform.position.x < player.transform.position.x)
    //    {
    //        rb2d.velocity = new Vector2(moveSpeed, 0);
    //        animator.SetBool("Right", true);
    //        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), moveSpeed * Time.deltaTime);
    //    }
    //    else
    //    {
    //        rb2d.velocity = new Vector2(-moveSpeed, 0);
    //        animator.SetBool("Right", false);
    //        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, transform.position.y), moveSpeed * Time.deltaTime);
    //    }
    //    animator.SetBool("Notice", true);
    //}
    //void StopChasingPlayer()
    //{
    //    rb2d.velocity = Vector2.zero;
    //    animator.SetBool("Notice", false);
    //}
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    // if(collision.CompareTag("Player")){
    //    //     whenTouchPlayer?.Invoke();
    //    //     Destroy(player);
    //    // }
    //    if (collision.CompareTag("Player"))
    //    {
    //        Debug.Log("GAME OVER");
    //    }
    //}
}