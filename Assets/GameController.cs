using UnityEngine;
using TMPro;


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
    SceneController sceneController;


    // Start is called before the first frame update
    void Start()
    {
        leftScore = leftScoreText.GetComponent<TextMeshProUGUI>();
        rightScore = rightScoreText.GetComponent<TextMeshProUGUI>();

        leftScore.text = leftScoreInt.ToString();
        rightScore.text = rightScoreInt.ToString();

        ballController = FindObjectOfType<Ball_Controller>();
        sceneController = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // DRY up the two functions below
    public void leftGoalIn()
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
            print("Right wins!");
            sceneController.gameOn = false;
        }        
    }

    public void rightGoalIn()
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
            print("Left wins!");
            sceneController.gameOn = false;
        }
    }
}
