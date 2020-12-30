using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]

public class Watching : MonoBehaviour
{
    [SerializeField] [Range(0, 10f)] private float _distance;
    [SerializeField] private UnityEvent _playerWatched;

    private LayerMask _mask;
    private SpriteRenderer _renderer;
    private int _lookDirection;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _mask = LayerMask.GetMask("Player");
    }

    private void Update()
    {
        if (_renderer.flipX)
            _lookDirection = -1;
        else
            _lookDirection = 1;


        RaycastHit2D watched = Physics2D.Raycast(transform.position, _lookDirection * transform.right, _distance, _mask);

        Debug.DrawRay(transform.position, _lookDirection * transform.right * _distance, Color.red);

        if (watched)
        {
            _playerWatched?.Invoke();
        }
    }
}
