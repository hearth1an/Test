using UnityEngine;

public class Mover : MonoBehaviour
{   
    private float _value = 0.5f;

    void Update()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z += _value * Time.deltaTime;
        transform.position = nextPosition;
    }
}
