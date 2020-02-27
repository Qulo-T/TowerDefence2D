using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private GameObject _target;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(_target.transform.position * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, _target.transform.position) < 0.2f)
        {
            //вызвать эффект gameobject.GetComponent<AEffects>().RunEffect();
            
            Destroy(gameObject);
        }
    }

    public void SetTarget(GameObject target)
    {
        _target = target;
    }
}
