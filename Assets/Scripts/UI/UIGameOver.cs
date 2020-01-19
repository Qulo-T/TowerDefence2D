using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private Text gameoverText;
    [SerializeField] private GameObject resumeButton;

    public void GameOver(int kills)
    {
        Time.timeScale = 0;
        GameControlls.finishGame = true;
        gameoverText.text = "Game Over" + "\n" + "Kills: " + kills;
        resumeButton.SetActive(false);
        gameObject.SetActive(true);
    }
}
