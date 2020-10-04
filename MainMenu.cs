using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame(int num)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + num);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
