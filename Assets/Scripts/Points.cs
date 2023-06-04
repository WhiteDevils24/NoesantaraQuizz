using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;
    public GameObject winPanel;

    private int score = 0;
    public int maxScore = 100;
    public int pointsToAdd = 10;
    public int pointsToSubtract = 5;
    private bool isGameOver = false;
    private bool isGameWon = false;

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AnswerCorrect()
    {
        if (isGameOver || isGameWon)
            return;

        score += pointsToAdd;
        CheckGameWon();
        UpdateScoreUI();
    }

    public void AnswerWrong()
    {
        if (isGameOver || isGameWon)
            return;

        score -= pointsToSubtract;
        CheckGameOver();
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;

        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
        }
        else if (isGameWon)
        {
            winPanel.SetActive(true);
        }
    }

    private void CheckGameOver()
    {
        if (score <= 0)
        {
            isGameOver = true;
        }
    }

    private void CheckGameWon()
    {
        if (score >= maxScore)
        {
            isGameWon = true;
        }
    }
}

