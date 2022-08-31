using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField]private Rigidbody2D spawnPoint;

    private Camera  mainCamera;

    public void SpawnBall()
    {
        GameObject ballInstance = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }
}
