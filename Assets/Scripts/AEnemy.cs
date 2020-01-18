using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEnemy : MonoBehaviour, ItakenDamage
{
    [SerializeField] private int health;
    [SerializeField] private int damage;
    [SerializeField] private int reward;
    [SerializeField] private float mfSpeed = 1;

    private float speed;
    private int waypointIndex = 0;

    private Player player;
    private GameControlls gameControlls;
    private List<GameObject> waypoints = new List<GameObject>();


    void Start()
    {

        gameControlls = transform.parent.gameObject.GetComponent<Spawner>().gameControlls;
        player = transform.parent.gameObject.GetComponent<Spawner>().player;

        speed = gameControlls.GetSpeed * mfSpeed;
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

        if (Vector3.Distance(transform.position, wayPosition) < 0.2f)
        {
            if (waypointIndex < waypoints.Count - 1)
            {
                waypointIndex++;
            }
            else
            {
                player.TakenDamage(damage);
                Destroy(gameObject);
            }
        }
    }

    public void TakenDamage(int damage)
    {
        health -= damage;
        isAlive();
    }

    public void isAlive()
    {
        if (health <= 0)

        {
            player.TakenReward(reward);
            player.AddFrag();
            Destroy(gameObject);
        }
    }

}
