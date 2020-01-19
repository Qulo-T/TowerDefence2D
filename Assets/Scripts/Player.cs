﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour, ItakenDamage
{
    public GameControlls gameControlls;
    public UIManager uiManager;

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
    }

    public void TakenReward(int reward)
    {
        _gold += reward;
        uiManager.top.Gold(_gold);
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
            uiManager.top.Health(0);
            uiManager.gameoverPanel.GameOver(_kills);
        }
        else
        {
            uiManager.top.Health(_health);
        }
    }
    
}
