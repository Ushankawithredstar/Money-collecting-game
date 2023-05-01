using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    
    private string currentState;
    
    private PlayerInput playerInput;

    private bool facingLeft = false;

    const string PLAYER_IDLE = "Player_idle";
    const string PLAYER_WALK = "Player_walk";

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
    }
    
    private void FixedUpdate()
    {
        AnimatePlayer();
        RotatePlayer();
    }

    private void ChangeAnimationState(string newState)
    {
        if (currentState == newState)
            return;

        anim.Play(newState);

        currentState = newState;
    }

    private void AnimatePlayer()
    {
        if (playerInput.Horizontal > 0)
            ChangeAnimationState(PLAYER_WALK);
        else if (playerInput.Horizontal < 0)
            ChangeAnimationState(PLAYER_WALK);
        else if (playerInput.Horizontal == 0)
            ChangeAnimationState(PLAYER_IDLE);
    }

    private void RotatePlayer()
    {
        if (facingLeft && playerInput.Horizontal > 0)
        {
            transform.Rotate(0f, 180f, 0f);
            facingLeft = false;
        }
        else if (!facingLeft && playerInput.Horizontal < 0)
        {
            transform.Rotate(0f, -180f, 0f);
            facingLeft = true;
        }
    }
}