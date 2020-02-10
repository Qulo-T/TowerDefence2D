using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glObjects : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private Player player;
    [SerializeField] private GameControlls gameControlls;
    [SerializeField] private Shop shop;

    public static Player playerGL { get; private set; }
    public static UIManager uiManagerGL { get; private set; }
    public static GameControlls controllsGL { get; private set; }
    public static Shop shopGL { get; private set; }
    
    private void Start()
    {
        if (playerGL == null)
        {
            playerGL = player;
        }

        if (uiManagerGL == null)
        {
            uiManagerGL = uiManager;
        }

        if (controllsGL == null)
        {
            controllsGL = gameControlls;
        }

        if (shopGL == null)
        {
            shopGL = shop;
        }
    }
}
