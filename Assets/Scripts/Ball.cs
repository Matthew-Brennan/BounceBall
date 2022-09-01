using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {   
        
        GameObject objectHit = collision.collider.gameObject;

        if(collision.collider.tag == "Ball" )
        {
            Debug.Log("Ball Hit");
            Physics2D.IgnoreCollision(collision.collider, collision.otherCollider);
        }

        if(collision.collider.tag == "Player")
        {
            objectHit.GetComponent<PlayerHit>().IncrementScore();
        }

        if(collision.collider.tag == "Wall")
        {
           objectHit.GetComponent<Boundary>().SpawnBall();
        }

        if(collision.collider.tag == "Floor")
        {
            objectHit.GetComponent<BottomBoundary>().GameOver();
        }
    }
}
