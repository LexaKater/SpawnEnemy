using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed = 2f;

    private void Update() => Move();

    public void TakeDirection(Vector3 direction) => _direction = direction;

    private void Move() => transform.Translate(_direction * _speed * Time.deltaTime);

}
