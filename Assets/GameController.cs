using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameController : MonoBehaviour
{
    int leftScoreInt = 0;
    int rightScoreInt = 0;
    [SerializeField] GameObject leftScoreText;
    [SerializeField] GameObject rightScoreText;
    TextMeshProUGUI leftScore;
    TextMeshProUGUI rightScore;
    LeftGoalBallIn leftGoal;


    // Start is called before the first frame update
    void Start()
    {
        leftScore = leftScoreText.GetComponent<TextMeshProUGUI>();
        rightScore = rightScoreText.GetComponent<TextMeshProUGUI>();

        leftScore.text = leftScoreInt.ToString();
        rightScore.text = rightScoreInt.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Can I combine the two goal in functions?
    public void leftGoalIn()
    {
        leftScoreInt += 1;
        leftScore.text = leftScoreInt.ToString();
    }

    public void rightGoalIn()
    {
        rightScoreInt += 1;
        rightScore.text = rightScoreInt.ToString();
    }
}
