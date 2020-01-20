using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBottom : MonoBehaviour
{
    [SerializeField] private Text _damagePoint;
    [SerializeField] private Text _fireRatePoint;
    [SerializeField] private Text _costUpgrade;
    [SerializeField] private Image _icon;
    [SerializeField] private Player _player;
    [SerializeField] private Button _firerateButton;

    private GameObject _tower;
    private ATower _atower;
    private TowerUpgrade _towerUpgrade;

    private int gold;
    private int costUP;

    public void SetTower(GameObject tw)
    {

        _tower = tw;
        _icon.sprite = _tower.GetComponent<SpriteRenderer>().sprite;
        _atower = _tower.GetComponent<ATower>();
        _towerUpgrade = _tower.GetComponent<TowerUpgrade>();
        CanFirerateUp();
        MoneyUpdate();
        UIupdate();
    }

    public void UpgradeDamage() //button
    {
        if (_tower != null)
        {
            if (gold >= costUP)
            {
                _towerUpgrade.UpgradeDamage();
                _player.Buy(costUP);
            }
            MoneyUpdate();
            UIupdate();
        }
    }
    public void UpgradeFireRate() //button
    {
        if (_tower != null)
        {
            if (gold >= costUP)
            {
                _towerUpgrade.UpgradeFireRate();
                _player.Buy(costUP);
            }
            MoneyUpdate();
            UIupdate();
            CanFirerateUp();
        }
    }

    private void UIupdate()
    {
        _damagePoint.text = "" + _atower.Damage;
        _fireRatePoint.text = "" + _atower.BaseCooldown;
        _costUpgrade.text = "Cost: " + costUP;
    }
    public void MoneyUpdate()
    {
        gold = _player.Gold;

        if (_tower != null)
        {
            costUP = _towerUpgrade.Costup;
        }
    }
    private void CanFirerateUp()
    {
        if (_towerUpgrade.CanUpdate())
        {
            _firerateButton.interactable = true;
        }
        else
        {
            _firerateButton.interactable = false;
        }
    }

}
