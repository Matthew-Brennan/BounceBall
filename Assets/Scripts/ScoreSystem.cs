using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private float score = 0;

    public void IncrementScore() 
    {   
        score++;
        Debug.Log("Score: " + score.ToString());
        scoreText.text = score.ToString();  
    }
}
