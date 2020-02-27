using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private GameObject _bulletPrefab;
    private float _baseCooldown;

    private float _cooldown;

    private SearchTarget _searchTarget;
    private GameObject _target;

    private void Start()
    {
        _searchTarget = GetComponent<SearchTarget>();

        if (_searchTarget == null)
        {
            Debug.Log("Component SearchTarget not found. Your need to add it to "+gameObject.name);
            
        }
    }
    void Update()
    {
        if (_searchTarget != null)
        {
            _target = _searchTarget.GetTarget;
        }

        if (CanShoot() && _target != null)
        {
            Shoot();
        }

        if (_cooldown > 0)
        {
            _cooldown -= Time.deltaTime;
        }
    }

    private bool CanShoot()
    {
        if (_cooldown <= 0)
        {
            return true;
        }
        return false;
    }

    private void Shoot()
    {
        _cooldown = _baseCooldown;
        GameObject bullet = Instantiate(_bulletPrefab);
        bullet.GetComponent<BulletMove>().SetTarget(_target);
        bullet.transform.SetParent(gameObject.transform, false);

    }

    public void SetShootData(float baseCooldown, GameObject bulletPrefab)
    {
        _baseCooldown = baseCooldown;
        _bulletPrefab = bulletPrefab;
    }

}
