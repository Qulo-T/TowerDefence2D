using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ItakenDamage
{
    public GameControlls gameControlls;

    private int _health;
    private int _gold;
    private int _kills;


    void Start()
    {
        _health = gameControlls.GetPlayerHP;
        _gold = gameControlls.GetBaseGold;
    }

    public void AddFrag()
    {
        _kills++;
        Debug.Log("kills++");
    }

    public void TakenReward(int reward)
    {
        _gold += reward;
        Debug.Log("takenReward");
    }

    public void TakenDamage(int damage)
    {
        Debug.Log("TakenDamage");
        _health -= damage;
        isAlive();
    }

    public void isAlive()
    {
        if (_health <= 0)
        {
            Debug.Log("gameover");
            Time.timeScale = 0;
        }
    }
}
