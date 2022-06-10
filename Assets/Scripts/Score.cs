using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public int rightScore;
    public int leftScore;
    public int maxScore;
    public Ball bola;

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        bola.ResetBall();

        if (rightScore >= maxScore)
        {
            GameOver();
        } 
    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;

        if (leftScore >= maxScore)
        {
            GameOver();
        } 
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
