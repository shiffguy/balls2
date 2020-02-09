using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject life1, life2, life3, gameOver, timer, win, RestartButton;
    public static int lives = 3;
    public static int level = 0;
    // Start is called before the first frame update
    void Start()
    {

        BallLauncher.launched = false;
        timer.gameObject.SetActive(true);
        life1.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        switch (lives)
        {
            case 3:
                timer.gameObject.SetActive(true);
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                gameOver.gameObject.SetActive(false);
                timer.gameObject.SetActive(true);
                break;
            case 2:
                
                timer.gameObject.SetActive(true);
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false);
                break;
            case 1:
                timer.gameObject.SetActive(true);
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false);
                break;
            case 0:
                life1.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                timer.gameObject.SetActive(false);
                RestartButton.gameObject.SetActive(true);
                Terminate();
                break;
            case 5:
                
                win.gameObject.SetActive(true);
                life1.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(false);
                timer.gameObject.SetActive(false);
                RestartButton.gameObject.SetActive(true);
                Terminate();
                break;
        }

    }

    public void Terminate()
    {
        Time.timeScale = 0;
    }
}
