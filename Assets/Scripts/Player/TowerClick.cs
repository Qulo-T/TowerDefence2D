using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerClick : MonoBehaviour
{
    public UIManager _uiManager;
    void Start()
    {
        _uiManager = glObjects.uiManagerGL;
    }

    private void OnMouseDown()
    {
        _uiManager.SetTower(gameObject);
    }
}
