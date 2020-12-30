using UnityEngine;

public class ChickensDie : MonoBehaviour
{
    [SerializeField] [Range(0f, 3f)] private float _delayTimeToDestroy;
    
    public void OnChickenHit()
    {
        Destroy(gameObject, _delayTimeToDestroy);
    }
}
