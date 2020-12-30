using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsGrounded { get; private set; }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Ground>(out Ground ground))
            IsGrounded = true;
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Ground>(out Ground ground))
            IsGrounded = false;
    }    
}
