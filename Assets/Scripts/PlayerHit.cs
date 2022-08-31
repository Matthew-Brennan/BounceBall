using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHit : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private float score = 0;

    public void IncrementScore() 
    {   
        score++;
        scoreText.text = score.ToString();  
    }
        
    
}
