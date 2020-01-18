using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ATower : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private int damage;
    [SerializeField] private float baseCooldown;
    private float cooldown;

    void Update()
    {
        if (CanShoot())
        {
            SearchTarget();
        }

        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }

    bool CanShoot() 
    {
        if (cooldown <=0)
        {
            return true;
        }
        return false;
    } 

    void SearchTarget()
    {
        Transform target = null;
        float targetDistance = Mathf.Infinity;

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float currentDistance = Vector2.Distance(transform.position, enemy.transform.position);

            if (currentDistance < targetDistance && currentDistance < range)
            {
                target = enemy.transform;
                targetDistance = currentDistance;
            }
        }

        if (target!=null)
        {
            Shoot(target);
        }
    }

    void Shoot(Transform target)
    {
        cooldown = baseCooldown;
        target.gameObject.GetComponent<AEnemy>().TakenDamage(damage);
    }
}
