using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIObjectiveController : MonoBehaviour
{
    
    public Button play;

    private void Start()
    {
        play.onClick.AddListener(startPlaying);
    }

    private void startPlaying()
    {
        GameController.instance.StartPlaying();
    }
}
