using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlls : MonoBehaviour
{
    public static bool finishGame = false;

    [SerializeField] private float _enemySpeed;
    [SerializeField] private float _timeToSpawn;
    [SerializeField] private GameObject _wayPoints;
    [SerializeField] private int _baseGold;
    [SerializeField] private int _playerHP;
    [SerializeField] private int _baseEnemyCount;
    [SerializeField] private List<GameObject> _towerList;

    public float GetSpeed { get { return _enemySpeed; } }
    public float GetTimeSpawn { get { return _timeToSpawn; } }
    public int GetBaseGold { get { return _baseGold; } }
    public int GetPlayerHP { get { return _playerHP; } }
    public int GetBaseEnemyCount { get { return _baseEnemyCount; } }
    public List<GameObject> GetTowerList { get { return _towerList; } }
    public List<GameObject> GetWayPoints
    {
        get
        {
            List<GameObject> list = new List<GameObject>();
            for (int i = 0; i < _wayPoints.transform.childCount; i++)
            {
                list.Add(_wayPoints.transform.GetChild(i).gameObject);
            }
            return list;
        }
    }



}

