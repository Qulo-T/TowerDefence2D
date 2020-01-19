using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameControlls gameControlls;
    public Player player;
    public UIManager uiManager;

    private float _baseTimeToSpawn;

    private float _timeToSpawn;
    private int _spawnCount = 1;
    private int _baseEnemyCount;

    public GameObject enemyPref;
    void Start()
    {
        _baseEnemyCount = gameControlls.GetBaseEnemyCount;
        _baseTimeToSpawn = gameControlls.GetTimeSpawn;
        _timeToSpawn = _baseTimeToSpawn;

    }


    void Update()
    {
        if (_timeToSpawn <= 0)
        {
            StartCoroutine(SpawnEnemy());
            _timeToSpawn = _baseTimeToSpawn;
        }

        _timeToSpawn -= Time.deltaTime;
        uiManager.Timer(_timeToSpawn);
    }

    private int EnemyCount()
    {
        int count = Random.Range(_spawnCount, _spawnCount + _baseEnemyCount);
        return count;
    }

    IEnumerator SpawnEnemy()
    {
        int enemyCount = EnemyCount();

        _spawnCount++;

        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemy = Instantiate(enemyPref);

            enemy.transform.SetParent(gameObject.transform, false);

            yield return new WaitForSeconds(0.4f);
        }
    }
}
