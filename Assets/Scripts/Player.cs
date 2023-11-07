using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D playerRigidbody2D;
    public float velocidade = 50.0f ;
    public float entradaHorizontal ;
    public float entradaVertical ;

    void Start()
    {
        Debug.Log("Start de " + this.name);
        animator = GetComponent<Animator>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        float velocidade = 50.0f ;
    }

    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
            entradaHorizontal = Input.GetAxisRaw("Horizontal");
            transform.Translate(Vector3.right*Time.deltaTime*velocidade*entradaHorizontal);

            entradaVertical = Input.GetAxisRaw("Vertical");
            transform.Translate(Vector3.up*Time.deltaTime*velocidade*entradaVertical);

        // playerRigidbody2D.MovePosition(newPosition);

        if (entradaVertical > 0)
        {
            animator.SetBool("Walk_Side", true);
        }
        else
        {
            animator.SetBool("Walk_Side", false);
        }

        if (entradaHorizontal < 0)
        {
            animator.SetBool("Walk_Left", true);
        }
        else
        {
            animator.SetBool("Walk_Left", false);
        }

        if (entradaVertical < 0)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }

        if (entradaHorizontal > 0)
        {
            animator.SetBool("Walk_Right", true);
        }
        else
        {
            animator.SetBool("Walk_Right", false);
        }
    }

}

