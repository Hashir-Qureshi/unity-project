using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMaster : MonoBehaviour {
    public int numOfEnemies;
    public Text enemyCounter;
    public FloatValue playerHealth;
    public IntValue time;
    public Text endingText;
    public Text endingSubText;
    public GameObject gameOverScreen;
    public int gameTime = 0;

	// Use this for initialization
	void Awake () {
        time.RuntimeValue = gameTime;

    }

    // Update is called once per frame
    void Update () {
        CountEnemies();
        UpdateEnemyCounter();
        CheckGameOver();
	}


    private void CountEnemies()
    {
        numOfEnemies = GameObject.FindGameObjectsWithTag("enemy").Length;
    }
    private void UpdateEnemyCounter()
    {
        enemyCounter.text = "Enemies: " + numOfEnemies;
    }

    public void CheckGameOver()
    {
        if(playerHealth.RuntimeValue == 0)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
            endingText.text = "YOU DED";
            endingSubText.text = "It won't hurt to try again...";
        }
        else if(numOfEnemies == 0)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
            endingText.text = "You Win!";
            endingSubText.text = "You killed them all!";
        }
        else if (time.RuntimeValue <= 0)
        {
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
            endingText.text = "Game Over!";
            endingSubText.text = "You couldn't kill the enemies in time! Better luck next time.";
        }
    }
}
