using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] int leftScoreInt = 0;
    [SerializeField] int rightScoreInt = 0;
    [SerializeField] GameObject leftScoreText;
    [SerializeField] GameObject rightScoreText;
    TextMeshProUGUI leftScore;
    TextMeshProUGUI rightScore;
    LeftGoalBallIn leftGoal;
    Ball_Controller ballController;


    // Start is called before the first frame update
    void Start()
    {
        leftScore = leftScoreText.GetComponent<TextMeshProUGUI>();
        rightScore = rightScoreText.GetComponent<TextMeshProUGUI>();

        leftScore.text = leftScoreInt.ToString();
        rightScore.text = rightScoreInt.ToString();

        ballController = FindObjectOfType<Ball_Controller>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Can I combine the two goal in functions?
    public void leftGoalIn()
    {
        if (leftScoreInt < 10)
        {
            leftScoreInt += 1;
            leftScore.text = leftScoreInt.ToString();
            ballController.LaunchBall();
        }
        else
        {
            leftScoreInt += 1;
            leftScore.text = leftScoreInt.ToString();
            print("Right wins!");
        }
        
    }

    public void rightGoalIn()
    {
        if (rightScoreInt < 10)
        {
            rightScoreInt += 1;
            rightScore.text = rightScoreInt.ToString();
            ballController.LaunchBall();
        }
        else
        {
            rightScoreInt += 1;
            rightScore.text = rightScoreInt.ToString();
            print("Left wins!");
        }
        
    }
}
