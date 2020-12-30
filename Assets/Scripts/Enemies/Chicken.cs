using UnityEngine;
using UnityEngine.Events;

public class Chicken : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;
    
    public event UnityAction Hit
    {
        add => _hit.AddListener(value);
        remove => _hit.RemoveListener(value);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
            _hit?.Invoke();
    }
}
