using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField]private Rigidbody2D spawnPoint;
    private float verticleAccel = 2f;
    private float HorizontalAccel = 1.5f;
    private Rigidbody2D rb;


    private Camera  mainCamera;

    public void SpawnBall(GameObject currentBall, GameObject wall)
    {
        GameObject ballInstance = Instantiate(ballPrefab, currentBall.transform.position, Quaternion.identity);
        rb = ballInstance.GetComponent<Rigidbody2D>();

        if (wall.name == "LeftBoundaryBarrier")
        {
            rb.velocity = new Vector2(HorizontalAccel, verticleAccel);
        }
        else
        {
            rb.velocity = new Vector2(-HorizontalAccel, verticleAccel);
        }
        //ballInstance.GetComponent<Rigidbody2D>().velocity(1f,2f);
    }
}
