using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    [SerializeField] private int _damageUP;
    [SerializeField] private float _decreaseCooldown;
    [SerializeField] private int _costUpStep;
    [SerializeField] private float _minCooldown;
    private int _costUP;
    private ATower _tower;
    private int _damage;
    private float _cooldown;

    void Start()
    {
        _tower = GetComponent<ATower>();
        _damage = _tower.Damage;
        _cooldown = _tower.BaseCooldown;
        _costUP = _costUpStep;
    }

    public void UpgradeDamage()
    {
        _damage += _damageUP;
        _tower.Damage = _damage;

        _costUP += _costUpStep;
    }

    public void UpgradeFireRate()
    {
        _cooldown -= _decreaseCooldown;
        if (_cooldown < _minCooldown)
        {
            _cooldown = _minCooldown;
        }
        _tower.BaseCooldown = _cooldown;

        _costUP += _costUpStep;
    }
    public bool CanUpdate()
    {
        if (_cooldown > _minCooldown)
        {           
            return true;
        }
        return false;
    }
    public int Costup { get { return _costUP; } }
}
