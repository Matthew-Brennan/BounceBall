using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float playerMoveSpeed = 7f;
    float dirX;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TiltMovement();
    }

    void FixedUpdate() 
    {
        rb.velocity = new Vector2 (dirX,0f);
    }

    void TiltMovement()
    {   
        dirX = Input.acceleration.x * playerMoveSpeed;
        transform.position = new Vector2 (Mathf.Clamp(transform.position.x, -1.72f, 1.72f), transform.position.y);
    }

    
}
