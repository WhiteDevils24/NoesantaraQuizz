using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public AudioSource audioSource;

    private bool isPaused = false;
    private float previousTimeScale;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = previousTimeScale;
        isPaused = false;
        audioSource.UnPause();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        previousTimeScale = Time.timeScale;
        Time.timeScale = 0f;
        isPaused = true;
        audioSource.Pause();
    }

    public void LoadMainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("StartMenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Keluar Dari Permainan");

    }
}
