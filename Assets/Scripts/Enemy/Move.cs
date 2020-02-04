using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _mfSpeed = 1; //для создания здоровых+медленных врагов или быстрых слабых.   
    private float speed;
    private int waypointIndex = 0;

    private GameControlls gameControlls;
    private protected Player player;
    private List<GameObject> waypoints = new List<GameObject>();

    private void Start()
    {
        gameControlls = transform.parent.gameObject.GetComponent<Spawner>().gameControlls;
        player = transform.parent.gameObject.GetComponent<Spawner>().player;

        speed = gameControlls.GetSpeed * _mfSpeed;
        waypoints = gameControlls.GetWayPoints;
    }
    void Update()
    {
        Moving();
    }

    void Moving()
    {
        Vector3 wayPosition = waypoints[waypointIndex].transform.position;
        Vector3 dir = wayPosition - transform.position;

        transform.Translate(dir.normalized * Time.deltaTime * speed);

        if (Vector3.Distance(transform.position, wayPosition) < 0.2f)
        {
            if (waypointIndex < waypoints.Count - 1)
            {
                waypointIndex++;
            }
            else
            {
                gameObject.GetComponent<AEnemy>().SetDamage(player);
                Destroy(gameObject);
            }
        }
    }
}
