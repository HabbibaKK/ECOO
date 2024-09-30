using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CanScoreTxt;
    [SerializeField] TextMeshProUGUI GlassScoreTxt;
    [SerializeField] TextMeshProUGUI MetalScoreTxt;

    [SerializeField] int CanScore;
    [SerializeField] int GlassScore;
    [SerializeField] int MetalScore;

    void Start()
    {
        CanScore = 0;
        GlassScore = 0;
        MetalScore = 0;

        CanScoreTxt.text = CanScore.ToString();
        GlassScoreTxt.text = GlassScore.ToString();
        MetalScoreTxt.text = MetalScore.ToString();
        Debug.Log("Start" + MetalScore);
    }

    private void Update()
    {
        Debug.Log(MetalScore);
    }
    public void UpdateCanScore()
    {
        CanScore++;
        CanScoreTxt.text = CanScore.ToString();
    }
    public void UpdateGlassScore()
    { 
        GlassScore++;
        GlassScoreTxt.text = GlassScore.ToString();
    }
    public void UpdateMetalScore() 
    { 
        MetalScore++;
        MetalScoreTxt.text = MetalScore.ToString();
    }
}
