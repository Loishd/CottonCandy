using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 5f;
    public float xlimit = 14.5f;
    public float ylimit = 11f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 input = new Vector2(horizontalInput, verticalInput).normalized;
        rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);

        
    }
}
