using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiBdion : MonoBehaviour
{
    public ScoreManager monScoreManager;

    private void Start()
    {
        monScoreManager = FindObjectOfType<ScoreManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(collision.gameObject);
        Destroy(gameObject);
        monScoreManager.score++;
    }
}