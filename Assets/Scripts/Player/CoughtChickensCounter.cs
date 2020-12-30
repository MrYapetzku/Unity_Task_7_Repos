using UnityEngine;
using TMPro;

public class CoughtChickensCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMesh;

    private int _chickensCounter = 0;

    private void Start()
    {
        _textMesh.text = _chickensCounter.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Chicken>(out Chicken chicken))
        {
            _chickensCounter++;
            _textMesh.text = _chickensCounter.ToString();
        }
    }
}