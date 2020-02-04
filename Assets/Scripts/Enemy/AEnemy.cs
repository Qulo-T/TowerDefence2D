using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEnemy : MonoBehaviour, ItakenDamage
{
    [SerializeField] private protected int _health;
    [SerializeField] private int _damage;
    [SerializeField] private protected int _reward;

    private protected Player player;

    void Start()
    {
        player = glObjects.playerGL;
    }
    public void TakenDamage(int damage)
    {
        _health -= damage;
        isAlive();
    }
    public void SetDamage(Player target)
    {
        target.TakenDamage(_damage);
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
