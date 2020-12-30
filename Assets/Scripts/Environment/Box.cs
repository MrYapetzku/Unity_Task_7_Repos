using UnityEngine;
using UnityEngine.Events;

public class Box : MonoBehaviour
{
    [SerializeField] private UnityEvent _hide;
    [SerializeField] private UnityEvent _unhide;

    private bool _isHide = false;
    private bool _isOnTheBox = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (_isHide)
            {
                _unhide?.Invoke();
                _isHide = false;
            }
            else
            {
                if (_isOnTheBox)
                {
                    _hide?.Invoke();
                    _isHide = true;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _isOnTheBox = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _isOnTheBox = false;
        }
    }
}
