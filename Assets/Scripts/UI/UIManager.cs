using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UITop top;
    [SerializeField] private UIBottom bottom;
    [SerializeField] private UIGameOver gameoverPanel;

    public void SetGold(int gold) 
    {
        top.Gold(gold);
        bottom.MoneyUpdate();
    }

    public void SetHealth(int health)
    {
        top.Health(health);
    }

    public void SetTimer(float timer)
    {
        top.Timer(timer);
    }

    public void SetTower(GameObject tower)
    {
        bottom.SetTower(tower);
    }

    public void GameOver(int kills)
    {
        gameoverPanel.GameOver(kills);
    }
}
