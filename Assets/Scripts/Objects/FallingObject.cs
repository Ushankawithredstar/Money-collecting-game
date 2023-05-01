using UnityEngine;

public class FallingObject : MonoBehaviour, Iscore
{
    public int Score {get; set;}
    // private int _score;

    private const string PLAYER_TAG = "Player";
    private const string GROUND_TAG = "Ground";

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            AddScore(1);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            AddScore(- Score);
            Destroy(gameObject);
        }
    }

    public virtual int AddScore(int amount) 
    {
        return Score + amount;
    }
}