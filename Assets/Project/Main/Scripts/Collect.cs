//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class ScoreManager : MonoBehaviour
//{
//    public int score = 0; // Use camelCase for consistency
//    public Text scoreText; // Reference to the UI Text component

//    void Start()
//    {
//        if (scoreText == null)
//        {
//            Debug.LogError("Score Text reference is missing!");
//            return;
//        }

//        UpdateScoreUI();
//    }

//    // Updates the score display in the UI
//    void UpdateScoreUI()
//    {
//        scoreText.text = "Score: " + score.ToString();
//    }

//    // Adds points to the score and updates the UI
//    public void AddScore(int points)
//    {
//        score += points;
//        UpdateScoreUI();
//    }
//}