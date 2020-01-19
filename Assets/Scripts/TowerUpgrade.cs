using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    [SerializeField] private int damageUP;
    [SerializeField] private float decreaseCooldown;
    [SerializeField] private int costUP;
    [SerializeField] private float minCooldown;
    private ATower tower;

    void Start()
    {
        tower = GetComponent<ATower>();
    }

    public void UpgradeDamage() 
    {
        int damage = tower.Damage;
        damage += damageUP;
        tower.Damage = damage;
    }

    public void UpgradeFireRate()
    {
        float cooldown = tower.BaseCooldown;
        cooldown -= decreaseCooldown;
        if (cooldown < minCooldown)
        {
            cooldown = minCooldown;
        }
        tower.BaseCooldown = cooldown;
    }

    public int Costup { get { return costUP; } }
}
