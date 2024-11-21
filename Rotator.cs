using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _number = 0.5f;
    private Vector3 _value;

    private void Start()
    {
        _value = new Vector3(0, _number , 0);
    }

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(_value * _speed * Time.deltaTime);
    }
}
