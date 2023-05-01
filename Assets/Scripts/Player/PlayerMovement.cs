using UnityEngine;

// [RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveForce = 10f;

    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (transform.position.x >= minX || transform.position.x <= maxX)
            transform.position += moveForce * Time.deltaTime * new Vector3(playerInput.Horizontal, 0, 0);
    }
}