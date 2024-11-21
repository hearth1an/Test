using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _number = 0.5f;
    private Vector3 _value;

    private void Start()
    {
        _value = Vector3.one * _number;
    }

    private void Update()
    {
        transform.localScale += _value * _speed * Time.deltaTime;
    }
}
