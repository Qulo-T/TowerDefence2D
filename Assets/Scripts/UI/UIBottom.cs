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
        CanFirerateUp();
        MoneyUpdate();
        UIupdate();
    }

    public void UpgradeDamage() //button
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
    public void UpgradeFireRate() //button
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
            CanFirerateUp();
        }
    }

    private void UIupdate()
    {
        damagePoint.text = "" + atower.Damage;
        fireRatePoint.text = "" + atower.BaseCooldown;
        costUpgrade.text = "Cost: " + costUP;
    }
    public void MoneyUpdate()
    {
        gold = player.Gold;

        if (tower != null)
        {
            costUP = towerUpgrade.Costup;
        }
    }
    private void CanFirerateUp()
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
