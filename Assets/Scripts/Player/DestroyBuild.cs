using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBuild : MonoBehaviour
{
    [SerializeField] private float _goldReturnMF;
    private int _level;
    private int _towerPrice;
    private int _upgradeCost;

    public void OnDestroy()
    {
        ReturnGold();
        gameObject.transform.parent.GetComponent<EmptyCell>().SetStatus(true);
    }

    private void ReturnGold()
    {
        _level = gameObject.GetComponent<TowerUpgrade>().Getlvl;
        _upgradeCost = gameObject.GetComponent<TowerUpgrade>().GetCostUpStep;
        _towerPrice = gameObject.GetComponent<ATower>().GetPrice;

        float goldReturn = 0;

        for (int i = 0; i < _level+1; i++)
        {
            goldReturn += i * _upgradeCost;
        }

        goldReturn += _towerPrice;
        goldReturn *= +_goldReturnMF;

        glObjects.playerGL.TakenReward((int)goldReturn);

    }
}
