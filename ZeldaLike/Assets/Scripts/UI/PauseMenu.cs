﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public static bool gamePaused;
    public GameObject pauseMenuUI;

	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
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
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        gamePaused = false;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
