using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Horizontal {get; private set; }

    private void FixedUpdate() 
    {
        Horizontal = Input.GetAxis("Horizontal");
    }
}