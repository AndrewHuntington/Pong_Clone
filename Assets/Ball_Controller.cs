using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    [SerializeField] float ballSpeed = 6f;
    [SerializeField] float randomFactor;
    Rigidbody2D rb;    

    // Start is called before the first frame update
    void Start()
    {
        //Ball chooses a direction
        //Flies in that direction
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    private void LaunchBall()
    {
        //determine direction in x and y axes
        int xDirection = Random.Range(0, 2);
        int yDirection = Random.Range(0, 3);

        Vector2 launchDirection = new Vector2();

        if (xDirection == 0)
        {
            launchDirection.x = -1f;
        }
        if (xDirection == 1)
        {
            launchDirection.x = 1f;
        }

        if (yDirection == 0)
        {
            launchDirection.y = -1f;
        }
        if (yDirection == 1)
        {
            launchDirection.y = 1f;
        }
        if (yDirection == 2)
        {
            launchDirection.y = 0;
        }

        rb.velocity = launchDirection * ballSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        randomFactor = Random.Range(-1f, 1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + randomFactor);
        }
    }
}
