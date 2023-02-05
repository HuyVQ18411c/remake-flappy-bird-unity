using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameScreen;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverScreen.SetActive(false);
        this.scoreText.gameObject.SetActive(true);
    }

    [ContextMenu("Add Score")]
    public void addScore(int score)
    {
        this.playerScore += score;
        scoreText.text = playerScore.ToString();
    }

    public void startGame()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        this.gameOverScreen.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
