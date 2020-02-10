using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    private GameObject _towerPref;

    public void SetTowerPref(GameObject towerPref)
    {
        _towerPref = towerPref;
    }
    public void ButtonBuy()
    {
        glObjects.shopGL.BuyTower(_towerPref);
    }

    public void CloseShop()
    {
        glObjects.shopGL.gameObject.SetActive(false);
    }
}
