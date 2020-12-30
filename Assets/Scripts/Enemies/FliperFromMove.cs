using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class FliperFromMove : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private float _pastPositionX;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _pastPositionX = transform.position.x;
    }

    private void Update()
    {
        if (transform.position.x < _pastPositionX)
            _renderer.flipX = true;
        else if (transform.position.x > _pastPositionX)
            _renderer.flipX = false;

        _pastPositionX = transform.position.x;
    }
}
