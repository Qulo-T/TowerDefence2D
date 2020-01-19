using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;

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
            if (menuPanel.activeSelf)
            {
                Time.timeScale = 1;
                menuPanel.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                menuPanel.SetActive(true);
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
