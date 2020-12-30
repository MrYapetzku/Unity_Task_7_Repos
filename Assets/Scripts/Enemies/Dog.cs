using UnityEngine;
using UnityEngine.Events;

public class Dog : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
            _hit?.Invoke();
    }
}
