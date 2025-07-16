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
        transform.position = new Vector2(transform.position.x + (horizontalInput * speed * Time.deltaTime), transform.position.y + (verticalInput * speed * Time.deltaTime));

        if (transform.position.x > xlimit)
        {
            transform.position = new Vector3(xlimit, transform.position.y, 0f);
        }

        else if (transform.position.x < -xlimit)
        {
            transform.position = new Vector3(-xlimit, transform.position.y, 0f);
        }

        if (transform.position.y > ylimit)
        {
            transform.position = new Vector3(transform.position.x, ylimit, 0f);
        }

        else if (transform.position.y < -ylimit)
        {
            transform.position = new Vector3(transform.position.x, -ylimit, 0f);
        }
    }
}
