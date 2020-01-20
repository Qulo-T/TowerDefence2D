using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEnemy : MonoBehaviour, ItakenDamage
{
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private int _reward;

    [SerializeField] private float _mfSpeed = 1; //для создания здоровых+медленных врагов или быстрых слабых.

    private float speed;
    private int waypointIndex = 0;

    private Player player;
    private GameControlls gameControlls;
    private List<GameObject> waypoints = new List<GameObject>();


    void Start()
    {

        gameControlls = transform.parent.gameObject.GetComponent<Spawner>().gameControlls;
        player = transform.parent.gameObject.GetComponent<Spawner>().player;

        speed = gameControlls.GetSpeed * _mfSpeed;
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
                player.TakenDamage(_damage);
                Destroy(gameObject);
            }
        }
    }

    public void TakenDamage(int damage)
    {
        _health -= damage;
        isAlive();
    }

    public void isAlive()
    {
        if (_health <= 0)

        {
            player.TakenReward(_reward);
            player.AddFrag();
            Destroy(gameObject);
        }
    }

    public void Upgrade(int hp, int dmg, int rwd)
    {
        _health += hp;
        _damage += dmg;
        _reward += rwd;
    }

}
