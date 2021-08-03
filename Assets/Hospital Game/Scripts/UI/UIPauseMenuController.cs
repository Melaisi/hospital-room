using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseMenuController : MonoBehaviour
{
    public Button resumeBtn;
    public Button settingsBtn;
    public Button exitBtn;

    private void Start()
    {
        resumeBtn.onClick.AddListener(resumeGame);
        exitBtn.onClick.AddListener(exitGame);
    }

    private void exitGame()
    {
        GameController.instance.EndGame();
    }

    private void resumeGame()
    {
        GameController.instance.ResumeGame();
    }
}
