using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    public Canvas levelObjective;
    public Canvas hud;
    public Canvas levelComplete;
    public Canvas pauseMenu;

    private void Start()
    {
        GameController.instance.onGameStateChange += onGamsStateChange;
    }
    private void OnDestroy()
    {

        GameController.instance.onGameStateChange -= onGamsStateChange;
    }

    private void onGamsStateChange(GameController.State from, GameController.State to)
    {
        if(from == GameController.State.MainMenu && to == GameController.State.PreGame)
        {
            displayCanvas(levelObjective);
            return;
        }
        if(to == GameController.State.Playing)
        {
            displayCanvas(hud);
            return;
        }
        if(to == GameController.State.Pause)
        {
            displayCanvas(pauseMenu);
            return;
        }
        if(to == GameController.State.End)
        {
            displayCanvas(levelComplete);
            return;
        }
    }

    private void displayCanvas(Canvas canvas)
    {
        hideAllCanvas();
        canvas.gameObject.SetActive(true);
    }

    private void hideAllCanvas()
    {
        levelObjective.gameObject.SetActive(false);
        hud.gameObject.SetActive(false);
        levelComplete.gameObject.SetActive(false);
    }

    public void showObjective()
    {
        displayCanvas(levelObjective);
        return;
    }
}
