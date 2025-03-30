using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject titleScreen;
    public bool isGameActive;
    public GameObject ball;
    public int score;
    public TextMeshProUGUI scoreText;
    public Button restartButton;
    public GameObject gameOverText;
    public int ballCount;





    // Start is called before the first frame update
    void Start()
    {
        ballCount = 1;
        isGameActive = false;
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        ball.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow) && !isGameActive)
        {
            StartGame();
            ball.gameObject.SetActive(true);

        }
        // If ball drops below play area, removes the ball and ticks down ball count.
        if (ball.transform.position.y < -15)
        {
            ball.gameObject.SetActive(false);
            ballCount = (ballCount - 1);
        }
        if (isGameActive && ballCount == 0)
        {
       
               // Can't for the life of me remember how this works. Pls help.
                GameOver();
            
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
       
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
