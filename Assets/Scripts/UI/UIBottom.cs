using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBottom : MonoBehaviour
{
    [SerializeField] private Text damagePoint;
    [SerializeField] private Text fireRatePoint;
    [SerializeField] private Text costUpgrade;
    [SerializeField] private Image icon;
    [SerializeField] private Player player;
    [SerializeField] private Button firerateButton;

    private GameObject tower;
    private ATower atower;
    private TowerUpgrade towerUpgrade;

    private int gold;
    private int costUP;

    public void SetTower(GameObject tw)
    {

        tower = tw;
        icon.sprite = tower.GetComponent<SpriteRenderer>().sprite;
        atower = tower.GetComponent<ATower>();
        towerUpgrade = tower.GetComponent<TowerUpgrade>();
        CanFirerateUpdate();
        MoneyUpdate();
        UIupdate();
    }

    public void UpgradeDamage()
    {
        if (tower != null)
        {
            if (gold >= costUP)
            {
                towerUpgrade.UpgradeDamage();
                player.Buy(costUP);
            }
            MoneyUpdate();
            UIupdate();
        }
    }
    public void UpgradeFireRate()
    {
        if (tower != null)
        {
            if (gold >= costUP)
            {
                towerUpgrade.UpgradeFireRate();
                player.Buy(costUP);
            }
            MoneyUpdate();
            UIupdate();
            CanFirerateUpdate();
        }
    }

    private void UIupdate()
    {
        gold = player.Gold;
        damagePoint.text = "" + atower.Damage;
        fireRatePoint.text = "" + atower.BaseCooldown;
        costUpgrade.text = "Cost: " + costUP;
    }
    private void MoneyUpdate()
    {
        gold = player.Gold;
        costUP = towerUpgrade.Costup;
    }
    private void CanFirerateUpdate()
    {
        if (towerUpgrade.CanUpdate())
        {
            firerateButton.interactable = true;
        }
        else
        {
            firerateButton.interactable = false;
        }
    }

}
