using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenClose();
        }
    }
    public void OpenClose()
    {
        if (!GameControlls.finishGame)
        {
            if (_menuPanel.activeSelf)
            {
                Time.timeScale = 1;
                _menuPanel.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                _menuPanel.SetActive(true);
            }
        }

    }
    public void StartGame()
    {
        GameControlls.finishGame = false;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }


}
