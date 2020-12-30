using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] [Range(0.5f, 5f)] private float _spawnTimeDelta;
    [SerializeField] private Chicken _chicken;

    private float _currentTime = 0f;
    private bool isSpawnPointEmpty = true;

    private void FixedUpdate()
    {
        _currentTime += Time.fixedDeltaTime;

        if (_currentTime >= _spawnTimeDelta)
        {
            if (isSpawnPointEmpty)
            {
                Instantiate(_chicken, transform.position, Quaternion.identity);
                isSpawnPointEmpty = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Chicken>(out Chicken chicken))
        {
            isSpawnPointEmpty = true;
            _currentTime = 0f;
        }
    }
}
