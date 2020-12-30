using UnityEngine;

public class PursuitMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;    

    private void Update()
    {        
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(_target.position.x, transform.position.y), _speed * Time.deltaTime);        
    }
}
