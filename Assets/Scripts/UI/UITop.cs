using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITop : MonoBehaviour
{
    [SerializeField] private Text _uiTimer;
    [SerializeField] private Text _uiGold;    
    [SerializeField] private Text _uiHealth;
    [SerializeField] private GameControlls _gameControlls;

    void Start()
    {      
        Health(_gameControlls.GetPlayerHP);
        Gold(_gameControlls.GetBaseGold);
    }
    public void Timer(float timer)
    {
        timer = Mathf.Ceil(timer);
        _uiTimer.text = "Next wave: " + timer;
    }

    public void Gold (int gold)
    {
        _uiGold.text ="Gold: "+ gold;
    }

    public void Health(int health) 
    {
        _uiHealth.text = "Health: " + health;
    }




}
