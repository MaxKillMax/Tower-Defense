using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private GameObject[] _enemiesPref;
    [SerializeField] private float _interval;
    [SerializeField] private int _waveEnemiesCount;
    [SerializeField] private int _countEnemies = 0;
    private float _timer;
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_waveEnemiesCount > _countEnemies)
        {
            if (_timer < _interval)
            {
                _timer += Time.deltaTime;
            }
            else
            {
                Spawn();
                _timer = 0;
                _countEnemies++;
            }
        }
    }
 
    private void Spawn()
    {
        Instantiate(_enemiesPref[0], new Vector3(_transform.position.x + Random.Range(0, 1.5f), _transform.position.y + Random.Range(0,1.5f),_transform.position.z), Quaternion.Euler(0,90,0));
    }
}
