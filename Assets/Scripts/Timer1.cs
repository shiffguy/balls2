﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer1 : MonoBehaviour
{
    public float timeLeft;
    public Text startText;
    private int temp;
    private string level;

    void Start()
    {
        startText = GetComponent<Text> ();
        timeLeft = 5.0f;
    }
    void Update()
    {
        
        if (!BallLauncher.launched)
        {
            
        }
        else
        {
            Time.timeScale = 1;
            timeLeft -= Time.deltaTime;
            startText.text = (timeLeft).ToString("0");
            if (timeLeft < 0)
            {
                GameControl.lives -= 1;
                BallLauncher.launched = false;
                timeLeft = 5.0f;
                level = "Scene" + GameControl.level;
                temp = GameControl.level;
                SceneManager.LoadScene(level);
                GameControl.level = temp;
            }    
        }
    }
}
