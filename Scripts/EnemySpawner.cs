using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private Vector3 _position;
    private Vector3 _direction;
    private Quaternion _rotation;

    private void Awake()
    {
        _position = transform.position;
        _rotation = transform.rotation;
    }

    public void CreateEnemy()
    {
        _enemy.transform.position = _position;
        _enemy.transform.rotation = _rotation;

        Enemy enemy = Instantiate(_enemy);
        enemy.TakeDirection(GetRandomDirection());
    }

    private Vector3 GetRandomDirection()
    {
        int minDirection = -2;
        int maxDirection = 3;

        _direction.x = UserUtils.GetRandomNumber(minDirection, maxDirection);
        _direction.z = UserUtils.GetRandomNumber(minDirection, maxDirection);

        return _direction;
    }
}