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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.L) && !isGameActive)
        {
            StartGame();
            ballCount = 1;
        }
        // If ball drops below play area, removes the ball and ticks down ball count.
        if (ball.transform.position.x > -6)
        {
            Destroy(gameObject);
            ballCount -= 1;
        }
        if (isGameActive)
        {
            // If ball count hits 0, end the game. (I need your help with this)
            if(ballCount == 0)
            {
                // Can't for the life of me remember how this works. Pls help.
                Invoke(GameOver);
            }
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

}
