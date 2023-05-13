using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreCalculator : MonoBehaviour
{
    // Settings

    // Connections

    // State Variables
    public int score;
    float tempScore;
    bool isDead;
    bool gameStarted;
    

    void Start()
    {
        InitConnections();
        InitState();
    }

    void InitConnections()
    {
        EventManager.gameStarted += OnGameStarted;
    }
    void InitState()
    {
        isDead = false;
        gameStarted = false;
    }

    void Update()
    {
        if (gameStarted)
        {
            CalculateScore();
        }
        else
        {
            score = 0;
        }
        
    }

    void CalculateScore()
    {
        if (!isDead)
        {
            tempScore += 0.1f;
            score = (int)tempScore;
        }
    }

    void OnGameStarted()
    {
        isDead = false;
        gameStarted = true;
    }

    private void OnDestroy()
    {
        EventManager.gameStarted -= OnGameStarted;
    }
}

