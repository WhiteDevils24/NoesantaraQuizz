using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLimit = 60f;  // Time limit in seconds
    public Text timerText;
    public GameObject gameOverPanel;
    public Button restartButton;
    public Button mainMenuButton;
    public AudioSource audioSource;
    public AudioClip timerOutClip;

    private float currentTime;
    private bool isGameOver = false;

    private void Start()
    {
        currentTime = timeLimit;
        UpdateTimerUI();
    }

    private void Update()
    {
        if (!isGameOver)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                TimeOut();
            }

            UpdateTimerUI();
        }
    }

    private void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void TimeOut()
    {
        isGameOver = true;
        audioSource.PlayOneShot(timerOutClip);
        // Perform any other time out actions
        GameOver();
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(ReturnToMainMenu);
        // Perform any other game over actions
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene("StartMenuScene"); // Replace "MainMenu" with the name of your main menu scene
    }

}
