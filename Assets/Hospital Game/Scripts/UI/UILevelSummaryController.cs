using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UILevelSummaryController : MonoBehaviour
{
    public Button restart;
    public TMP_Text levelSummary;
    public TMP_Text taskSummary;

    private void Start()
    {
        restart.onClick.AddListener(restartLevel);

       
        updateTaskDetails();
        updateLevelDetails();

    }
   

    private void updateLevelDetails()
    {
        levelSummary.SetText($"Your Score is {GameController.instance.getLevelScore()}");
    }

    private void updateTaskDetails()
    {
        taskSummary.SetText($"{GameController.instance.getTaskScore()} items out of 4 has been correctly placed in their location. ");
    }

    private void restartLevel()
    {
        GameController.instance.RestartGame();
    }

}
