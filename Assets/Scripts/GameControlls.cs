using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlls : MonoBehaviour
{

    [SerializeField] private int enemySpeed;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private GameObject wayPoints;
    [SerializeField] private int baseGold;
    [SerializeField] private int playerHP;

    public int GetSpeed { get { return enemySpeed; } }
    public float GetTimeSpawn { get { return timeToSpawn; } }
    public int GetBaseGold { get { return baseGold; } }
    public int GetPlayerHP { get { return playerHP; } }
    public List<GameObject> GetWayPoints
    {
        get
        {
            List<GameObject> list = new List<GameObject>();
            for (int i = 0; i < wayPoints.transform.childCount; i++)
            {
                list.Add(wayPoints.transform.GetChild(i).gameObject);
            }
            return list;
        }
    }



}

