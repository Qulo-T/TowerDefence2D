using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEffects : MonoBehaviour
{
    protected GameObject _target;

    public void RunEffect(GameObject target)
    {
        _target = target;
        Effect();
    }

    protected abstract void Effect();
}
