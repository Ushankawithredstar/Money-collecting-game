using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour, Iscore
{
    public int Score {get; set;}

    [SerializeField] private TextMeshProUGUI scoreCounterText; 
    // private TextMeshPro scoreCounter;

    private void Awake()
    {
        scoreCounterText = GetComponent<TextMeshProUGUI>();
        // scoreCounter = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        DisplayScore();
    }

    private void DisplayScore()
    {
        scoreCounterText.text = "Score: " + Score;
        // scoreCounter.text = "Score: " + Score;
    }
}