using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class RandomTimeFlip : MonoBehaviour
{
    [SerializeField] [Range(0f, 5f)] private float _maxFlipTime;

    private SpriteRenderer _spriteRenderer;
    private float _currentTime = 0f;
    private float _timeToFlip;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _timeToFlip = Random.Range(0f, _maxFlipTime);
    }

    private void FixedUpdate()
    {
        _currentTime += Time.fixedDeltaTime;

        if (_currentTime >= _timeToFlip)
        {
            if (_spriteRenderer.flipX)
                _spriteRenderer.flipX = false;
            else
                _spriteRenderer.flipX = true;

            _currentTime = 0f;
            _timeToFlip = Random.Range(0f, _maxFlipTime);
        }
    }
}
