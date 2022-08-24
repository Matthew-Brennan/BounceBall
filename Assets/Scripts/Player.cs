using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float playerMoveSpeed = 1f;
    float dirY;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TiltMovement();
    }

    void FixedUpdate() 
    {
        rb.velocity = new Vector2 (dirY,0f);
        transform.position = new Vector2 (Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }

    void TiltMovement()
    {
         dirY = Input.acceleration.y * playerMoveSpeed;
    }
}
