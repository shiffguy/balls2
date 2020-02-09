using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        string level = "Scene" + GameControl.level.ToString();
        GameControl.lives = 3;
        SceneManager.LoadScene(level);
        BallLauncher.launched = false;
    }
}
