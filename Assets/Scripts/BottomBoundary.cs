using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBoundary : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {   
        Debug.Log("bottom hit");
        other.GetComponent<BallHandler>().SpawnBall();
    }
}
