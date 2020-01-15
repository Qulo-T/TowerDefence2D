using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlls : MonoBehaviour
{
   private GameControlls gameControlls;
   private List<GameObject> waypoints = new List<GameObject>();
   

    int waypointIndex = 0;
    int speed; //добавить множитель скорости, в зависимости от типа врага

    void Start()
    {
        gameControlls = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameControlls>();
        
        speed = gameControlls.GetSpeed;
        waypoints = gameControlls.GetWayPoints;
    }

    void Update()
    {
        Move();
    }
    void Move() 
    {
        Vector3 wayPosition = waypoints[waypointIndex].transform.position;
        Vector3 dir = wayPosition - transform.position;

        transform.Translate(dir.normalized * Time.deltaTime * speed);

        if (Vector3.Distance(transform.position, wayPosition) < 0.1f)
        {
            if (waypointIndex < waypoints.Count -1)
            {
                waypointIndex++;
            }
            else
            {
                //прописать отнимание ХП
                Destroy(gameObject);
            }
        }
    }
}
