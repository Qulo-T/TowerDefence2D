using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpgrade : MonoBehaviour
{
    [SerializeField] private int _healthStep, _damageStep, _rewardStep;
    private int _damageUP = 0, _healthUP = 0, _rewardUP = 0;
    private List<int> _param = new List<int>();
    private List<int> _steps = new List<int>();

    void Start()
    {
        _steps.Add(_healthStep);
        _steps.Add(_damageStep);
        _steps.Add(_rewardStep);

        for (int i = 0; i < _steps.Count; i++)
        {
            _param.Add(0);
        }
    }

    public void RandomUpgrade()
    {
        for (int i = 0; i < _param.Count; i++)
        {
            if (Lucky())
            {
                _param[i] += _steps[i];
            }
        }        
    }

    public void SetUpgrade(GameObject enemy)
    {
        enemy.GetComponent<AEnemy>().Upgrade(_param[0], _param[1], _param[2]);
    }
    private bool Lucky()
    {
        int random = Mathf.RoundToInt(Random.Range(0, 2));
        if (random == 1)
        {
            return true;
        }

        return false;
    }

}


