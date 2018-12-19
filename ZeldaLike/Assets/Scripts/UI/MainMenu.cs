using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void LoadEasyMode()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("EasyLevel");
    }
    public void LoadMediumMode()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MediumLevel");
    }
    public void LoadHardMode()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("HardLevel");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
