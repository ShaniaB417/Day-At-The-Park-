using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text scoreText;
    public TMP_Text timerText;
    private int score = 0;
    private float timer = 0f;

    public float maxTime = 60f; // Maximum time for the game

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateScoreUI();
        UpdateTimerUI();
    }

    private void Update()
    {
        if (timer <= maxTime)
        {
            timer += Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            // Game over, reset timer and score
            ResetTimerAndScore();
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    public void ResetTimerAndScore()
    {
        timer = 0f;
        score = 0;
        UpdateTimerUI();
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
            timerText.text = "Time: " + Mathf.Max(0, maxTime - timer).ToString("0");
    }
}
