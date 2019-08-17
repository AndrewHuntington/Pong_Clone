using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour
{
    // Script that handles input from two players
    // Player 1 => Controls left bat with W/S keys
    // Player 2 => Controls right bat with arrow keys

    [SerializeField] GameObject leftPaddle;
    [SerializeField] GameObject rightPaddle;
    [SerializeField] float paddleSpeed = 20f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftPaddleControl();
        RightPaddleControl(); 
    }

    private void LeftPaddleControl()
    {
        //Stops movement
        leftPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            //Move the bat up
            leftPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.up * paddleSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //Move the bat down
            leftPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.down * paddleSpeed;
        }
    }

    private void RightPaddleControl()
    {
        //Stops movement
        rightPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Move the bat up
            rightPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.up * paddleSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the bat down
            rightPaddle.GetComponent<Rigidbody2D>().velocity = Vector2.down * paddleSpeed;
        }
    }
}
