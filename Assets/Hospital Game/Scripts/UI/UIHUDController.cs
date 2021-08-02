using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHUDController : MonoBehaviour
{

    public Button objectiveBtn;
    public Button exitBtn;
    public Button pauseBtn;

    private void Start()
    {
        objectiveBtn.onClick.AddListener(showObjective);
        exitBtn.onClick.AddListener(exitGame);
        pauseBtn.onClick.AddListener(pauseGame);

    }

    private void pauseGame()
    {
        GameController.instance.PauseGame();
    }

    private void exitGame()
    {
        GameController.instance.EndGame();
    }

    private void showObjective()
    {
        GameController.instance.ShowObjective();
    }
}
