using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGoalBallIn : MonoBehaviour
{
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D()
    {
        gameController.rightGoalIn();
    }
}
