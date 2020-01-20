using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpgrade : MonoBehaviour
{
    [SerializeField] private int healthStep, damageStep, rewardStep;
    private int damageUP = 0, healthUP = 0, rewardUP = 0;
    private List<int> param = new List<int>();
    private List<int> steps = new List<int>();

    void Start()
    {
        steps.Add(healthStep);
        steps.Add(damageStep);
        steps.Add(rewardStep);

        for (int i = 0; i < steps.Count; i++)
        {
            param.Add(0);
        }
    }

    public void RandomUpgrade()
    {
        for (int i = 0; i < param.Count; i++)
        {
            if (Lucky())
            {
                param[i] += steps[i];
            }
        }
        
    }

    public void SetUpgrade(GameObject enemy)
    {
        enemy.GetComponent<AEnemy>().Upgrade(param[0], param[1], param[2]);
    }
    private bool Lucky()
    {
        int random = Mathf.RoundToInt(Random.Range(0, 2));
        if (random == 1)
        {
            Debug.Log("lucky");
            return true;
        }
        Debug.Log("not lucky");
        return false;
    }

}


