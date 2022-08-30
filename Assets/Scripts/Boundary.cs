using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {   Debug.Log("side hit");
        other.GetComponent<BallHandler>().SpawnBall();
    }
}
