using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private Text _name;
    [SerializeField] private Text _dmg;
    [SerializeField] private Text _coolDown;
    [SerializeField] private Text _price;
    [SerializeField] private Button _buyButton;

    private GameObject _towerPref;
    private ATower _tower;

    public void SetShopData(GameObject target) 
    {
        _towerPref = target;
        _tower = target.GetComponent<ATower>();
        _icon.sprite = _towerPref.GetComponent<SpriteRenderer>().sprite;
        _name.text = _tower.GetName;
        _dmg.text = "" + _tower.Damage;
        _coolDown.text = "" + _tower.BaseCooldown;
        _price.text = "" + _tower.GetPrice;

        _buyButton.GetComponent<ShopButton>().SetTowerPref(_towerPref);
    }

}
