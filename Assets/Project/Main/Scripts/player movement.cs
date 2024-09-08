using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Animator animator;
    public float movespeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public float speed = 5f;
    public float jumpforce = 10f;
    void Update()
    {
        ProcessInputs();
    }
    private void FixedUpdate()
    {
        move();
    }
    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void move()
    {
        rb.velocity = new Vector2(moveDirection.x * movespeed, moveDirection.y * movespeed);
    }
}