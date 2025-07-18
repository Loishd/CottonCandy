using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerControl : MonoBehaviour
{

    public float speed = 3f;
    public float xlimit = 14.5f;
    public float ylimit = 11f;
    private Vector2 moveInput;

    private Rigidbody2D rb;
    private Animator animator; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        rb.velocity = moveInput * speed;
        
        
    }

    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("IsWalking", true);
        moveInput = context.ReadValue<Vector2>();

        if (context.canceled)
        {
            animator.SetBool("IsWalking", false);
        }
        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);
    }

}
