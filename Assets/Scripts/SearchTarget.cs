using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTarget : MonoBehaviour
{
    private int _enemyMask;
    private float _range;

    private GameObject target;

    void Update()
    {
        Search();
    }

    private void Search()
    {
        float minDistance = _range;

        RaycastHit2D[] hit = Physics2D.CircleCastAll(transform.position, _range, Vector2.zero, _range, _enemyMask);

        foreach (RaycastHit2D enemy in hit)
        {
            if (enemy.collider != null)
            {
                float currentDistance = Vector2.Distance(transform.position, enemy.transform.position);
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                    target = enemy.collider.gameObject;
                }

            }
        }

        if (hit.Length < 1)
        {
            target = null;
        }
    }

    public void SetTargetData(float range)
    {
        _range = range;
        _enemyMask = 1 << 2;
        _enemyMask = ~_enemyMask;
    }
    public void SetTargetData(float range, int enemyMask)
    {
        _range = range;
        _enemyMask = 1 << enemyMask;
    }

    public void ChangeMask(int mask, float duration) //for skill MindControll
    {
        StartCoroutine(MaskSwitch(mask, duration));
    }

    IEnumerator MaskSwitch(int mask, float duration) //for skill MindControll
    {
        int baseMask = _enemyMask;
        _enemyMask = 1 << mask;
        yield return new WaitForSeconds(duration);
        _enemyMask = baseMask;
    }

    public GameObject GetTarget { get { return target; } }
}
