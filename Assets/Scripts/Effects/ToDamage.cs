using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDamage : AEffects
{    
    protected override void Effect()
    {
        int damage = gameObject.GetComponent<ATower>().Damage;
        _target.GetComponent<AEnemy>().TakenDamage(damage);
        Debug.Log(damage);
    }
}
