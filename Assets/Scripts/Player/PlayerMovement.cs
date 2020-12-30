using UnityEngine;

[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Player))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Player _player;
    private Transform _transform;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            _transform.Translate(_speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.A))
            _transform.Translate(-_speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && _player.IsGrounded)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse); 
        }
    }
}
