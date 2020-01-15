using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlls : MonoBehaviour
{

    [SerializeField] private int enemySpeed;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private GameObject wayPoints;

    void Start()
    {

    }

    
    void Update()
    {

    }

    public int GetSpeed { get { return enemySpeed; } }
    public float GetTimeSpawn { get { return timeToSpawn; } }
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

