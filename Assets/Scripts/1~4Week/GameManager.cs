using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PointWall pointWall;
    public Text score;
    public Text playerScore;
    public int scorePoint;
    public GameObject gameEndPanel;
    public GameObject ball;
    public Image[] ballLife;
    public int ballLifeIndex = 9;

    void Awake()
    {

    }

    public void SetScore()
    {
        score.text = "Score: " + scorePoint;
    }

    public void UpdateBallLife()
    {
        ballLife[ballLifeIndex].color = new Color(1, 1, 1, 0);

        if(ballLifeIndex == 0)
        {
            GameEnd();
        }

        if (ballLifeIndex > 0)
        {
            ballLifeIndex--;
        }
    }

    public void GameEnd()
    {
        playerScore.text = "Your Score: " + scorePoint;
        gameEndPanel.SetActive(true);
        ball.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
