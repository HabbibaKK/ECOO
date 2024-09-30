using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] float remainingTime;
    private bool isGameOver = false;
     public bool isDone = false;

    void Awake()
    {
        // Singleton pattern implementation
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Optional: Persist the Timer across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicates
        }
    }

    void Update()
    {
        if (!isDone) {
            if (remainingTime > 0 && !isGameOver)
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime <= 0 && !isGameOver) // Trigger game over when time runs out
            {
                remainingTime = 0;
                isGameOver = true;
                GameOver();
            }

            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); 
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("Restart");

    }
}
