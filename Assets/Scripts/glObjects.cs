using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glObjects : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private Player player;

    public static Player playerGL { get; private set; }
    public static UIManager uiManagerGL { get; private set; }
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
    }
}
