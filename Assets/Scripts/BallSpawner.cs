using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField]private Rigidbody2D spawnPoint;

    private Camera  mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        SpawnBall();
    }


    public void SpawnBall()
    {
        GameObject ballInstance = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }

}
