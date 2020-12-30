using System.Collections;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]

public class AlfaFader : MonoBehaviour
{
    [SerializeField] [Range(0f, 5f)] private float _duration;

    private SpriteRenderer _spriteRenderer;
    private float _currentAlfa;
    private Coroutine _fadeAlfaProcess; 

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void StartFadeIn()
    {
        _spriteRenderer.DOFade(1, _duration);
    }

    public void StartFadeOut()
    {
        _spriteRenderer.DOFade(0, _duration);
    }    
}
