using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class OneShotPlayer : MonoBehaviour
{
    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void PlayBurk()
    {
        if (!_source.isPlaying)
        {
            _source.PlayOneShot(_source.clip);
        }
    }
}
