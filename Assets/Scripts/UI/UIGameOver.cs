using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private Text _gameoverText;
    [SerializeField] private GameObject _resumeButton;

    public void GameOver(int kills)
    {
        Time.timeScale = 0;
        GameControlls.finishGame = true;
        _gameoverText.text = "Game Over" + "\n" + "Kills: " + kills;
        _resumeButton.SetActive(false);
        gameObject.SetActive(true);
    }
}
