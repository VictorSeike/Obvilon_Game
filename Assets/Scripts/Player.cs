using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 500f;
    public Animator animator;
    private Rigidbody2D playerRigidbody2D;

    void Start()
    {
        Debug.Log("Start de " + this.name);
        animator = GetComponent<Animator>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movimento();
    }

    private void Movimento()
    {
        float movimentoHorizontal = Input.GetAxisRaw("Horizontal");
        float movimentoVertical = Input.GetAxisRaw("Vertical");

        Vector2 moveDirection = new Vector2(movimentoHorizontal, movimentoVertical).normalized;
        Vector2 newPosition = playerRigidbody2D.position + moveDirection * velocidade * Time.deltaTime;

        playerRigidbody2D.MovePosition(newPosition);

        if (movimentoVertical > 0)
        {
            animator.SetBool("Walk_Side", true);
        }
        else
        {
            animator.SetBool("Walk_Side", false);
        }

        if (movimentoHorizontal < 0)
        {
            animator.SetBool("Walk_Left", true);
        }
        else
        {
            animator.SetBool("Walk_Left", false);
        }

        if (movimentoVertical < 0)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }

        if (movimentoHorizontal > 0)
        {
            animator.SetBool("Walk_Right", true);
        }
        else
        {
            animator.SetBool("Walk_Right", false);
        }
    }
}