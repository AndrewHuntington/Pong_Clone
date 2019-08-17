using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    [SerializeField] float ballSpeed = 6f;
    [SerializeField] float randomFactor;
    [SerializeField] [Tooltip("1 = no change; 2 = double speed each time the ball hits a paddle")]
        [Range(1, 2)] float rampUpSpeed = 1.1f;
    Rigidbody2D rb;
    float timeToWaitInSeconds = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LaunchBall();       
    }

    public void LaunchBall()
    {
        StartCoroutine(BallLauncher());
    }

    private IEnumerator BallLauncher()
    {
        yield return new WaitForSecondsRealtime(timeToWaitInSeconds);

        //should reset the ball back to the middle
        transform.position = Vector2.zero;

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

    // When we hit something else...
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            rb.velocity = new Vector2(rb.velocity.x * rampUpSpeed, rb.velocity.y + randomFactor * rampUpSpeed);
        }
    }
}
