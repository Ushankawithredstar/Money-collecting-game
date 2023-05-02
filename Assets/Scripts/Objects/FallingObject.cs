using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";
    private const string GROUND_TAG = "Ground";

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            Score.AddScore(1);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            Score.AddScore(-Score.ScoreCount);
            Destroy(gameObject);
        }
    }
}