using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreCounterText; 

    private void Awake()
    {
        scoreCounterText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        DisplayScore();
    }

    private void DisplayScore()
    {
        scoreCounterText.text = "Score: " + Score.ScoreCount;
    }
}