using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameControlls _manager;
    private float _baseTimeToSpawn;

    private float _timeToSpawn;
    private int _spawnCount = 0;

    public GameObject enemyPref;
    void Start()
    {
        _manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameControlls>();
        _baseTimeToSpawn = _manager.GetTimeSpawn;
        _timeToSpawn = _baseTimeToSpawn;
    }


    void Update()
    {
        if (_timeToSpawn <= 0)
        {
            StartCoroutine(SpawnEnemy(_spawnCount + 1));
            _timeToSpawn = _baseTimeToSpawn;
        }

        _timeToSpawn -= Time.deltaTime;
    }

    IEnumerator SpawnEnemy(int enemyCount)
    {
        _spawnCount++;
        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemy = Instantiate(enemyPref);
            enemy.transform.SetParent(gameObject.transform, false);

            yield return new WaitForSeconds(0.4f);
        }
    }
}
