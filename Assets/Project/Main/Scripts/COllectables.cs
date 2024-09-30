using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COllectables : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Can"))
        {
            Destroy(other.gameObject);
            scoreManager.UpdateCanScore();
        }
        else if (other.CompareTag("Glass"))
        {
            Destroy(other.gameObject);
            scoreManager.UpdateGlassScore();
        }
        else if (other.CompareTag("Metal"))
        {
            Destroy(other.gameObject);
            scoreManager.UpdateMetalScore();
        }
    }
}
