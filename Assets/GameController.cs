using UnityEngine;
using TMPro;


public class GameController : MonoBehaviour
{
    [SerializeField] int leftScoreInt = 0;
    [SerializeField] int rightScoreInt = 0;
    [SerializeField] GameObject leftScoreText;
    [SerializeField] GameObject rightScoreText;
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject optionsCanvas;

    TextMeshProUGUI leftScore;
    TextMeshProUGUI rightScore;
    TextMeshProUGUI winnerText; // display if right or left won
    TextMeshProUGUI playAgainOrQuitText; // give options to play again or quit

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

        winCanvas.SetActive(false);
        optionsCanvas.SetActive(false);

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
            GameOver();
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
            GameOver();
        }
    }

    private void GameOver()
    {
        sceneController.gameOn = false;
        winCanvas.SetActive(true);
        optionsCanvas.SetActive(true);
        if (leftScoreInt == 11)
        {
            winCanvas.GetComponentInChildren<TextMeshProUGUI>().text = "Left Wins!";
        }
        else
        {
            winCanvas.GetComponentInChildren<TextMeshProUGUI>().text = "Right Wins!";
        }
        
    }
}
