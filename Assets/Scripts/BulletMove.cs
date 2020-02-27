using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GameObject _target;
    private AEffects[] effects;
    public float speed;


    void Update()
    {
        if (_target!=null)
        {
            Vector3 dir = _target.transform.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, _target.transform.position) < 0.2f)
            {
                effects = transform.parent.GetComponents<AEffects>();
                for (int i = 0; i < effects.Length; i++)
                {
                    effects[i].RunEffect(_target);
                }
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetTarget(GameObject target)
    {
        _target = target;
    }

}
