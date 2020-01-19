using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerClick : MonoBehaviour
{
    private UIManager uiManager;
    void Start()
    {
        uiManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<UIManager>();
    }

    private void OnMouseDown()
    {
        uiManager.bottom.SetTower(gameObject);
    }
}
