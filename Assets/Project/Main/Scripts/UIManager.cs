using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("ECO");
    }

   public void ExitGame()
    {
        Application.Quit();
    }
}
