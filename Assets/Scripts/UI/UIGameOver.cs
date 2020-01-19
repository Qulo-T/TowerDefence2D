using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private Text gameoverText;

    public void GameOver(int kills)
    {
        Time.timeScale = 0;
        gameoverText.text = "Game Over" + "\n" + "Kills: " + kills;
        gameObject.SetActive(true);
    }
}
