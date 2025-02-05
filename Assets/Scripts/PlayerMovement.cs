using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;
    private Vector2 moveInput; 

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical"); 
        moveInput.Normalize();
    }

    private void FixedUpdate()
    {
        rb.velocity = moveInput * playerSpeed;
    }
}
