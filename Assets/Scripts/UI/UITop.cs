using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITop : MonoBehaviour
{
    [SerializeField] private Text uiTimer;
    [SerializeField] private Text uiGold;    
    [SerializeField] private Text uiHealth;
    [SerializeField] private GameControlls gameControlls;

    void Start()
    {      
        Health(gameControlls.GetPlayerHP);
        Gold(gameControlls.GetBaseGold);
    }
    public void Timer(float timer)
    {
        timer = Mathf.Ceil(timer);
        uiTimer.text = "Next wave: " + timer;
    }

    public void Gold (int gold)
    {
        uiGold.text ="Gold: "+ gold;
    }

    public void Health(int health) 
    {
        uiHealth.text = "Health: " + health;
    }




}
