using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerClick : MonoBehaviour
{
    private UIManager _uiManager;
    void Start()
    {
        //сделано через Find, чтобы, в дальнейшем, при покупке башен не было ошибок.
        _uiManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<UIManager>();
    }

    private void OnMouseDown()
    {
        _uiManager.SetTower(gameObject);
    }
}
