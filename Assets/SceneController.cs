using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // makes more sense to be in GameController but that causes issues
    public bool gameOn = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();
    }

    private void GameStart()
    {
        if (Input.GetKey(KeyCode.Return) && !gameOn)
        {
            gameOn = true;
            SceneManager.LoadScene(1);
        }
    }
}
