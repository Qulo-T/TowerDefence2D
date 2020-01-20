using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UITop _top;
    [SerializeField] private UIBottom _bottom;
    [SerializeField] private UIGameOver _gameoverPanel;

    public void SetGold(int gold) 
    {
        _top.Gold(gold);
        _bottom.MoneyUpdate();
    }

    public void SetHealth(int health)
    {
        _top.Health(health);
    }

    public void SetTimer(float timer)
    {
        _top.Timer(timer);
    }

    public void SetTower(GameObject tower)
    {
        _bottom.SetTower(tower);
    }

    public void GameOver(int kills)
    {
        _gameoverPanel.GameOver(kills);
    }
}
