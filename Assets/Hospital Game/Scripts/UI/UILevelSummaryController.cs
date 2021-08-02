using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevelSummaryController : MonoBehaviour
{
    public Button restart;

    private void Start()
    {
        restart.onClick.AddListener(restartLevel);
    }

    private void restartLevel()
    {
        GameController.instance.RestartGame();
    }
}
