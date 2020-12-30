using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Player))]

public class PlayerAnimation : MonoBehaviour
{
    private Player _player;
    private Animator _animator;
    private SpriteRenderer _renderer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (_player.IsGrounded)
        {
            _animator.SetBool("Jump", false);

            if (Input.GetKey(KeyCode.D))
            {
                _renderer.flipX = false;
                _animator.SetBool("Run", true);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                _renderer.flipX = true;
                _animator.SetBool("Run", true);
            }
            else
            {
                _animator.SetBool("Run", false);
            }
        }
        else
        {
            _animator.SetBool("Run", false);
            _animator.SetBool("Jump", true);
        }

    }
}
