using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
