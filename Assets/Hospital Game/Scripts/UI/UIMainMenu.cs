using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button startBtn;


    private void Start()
    {
        startBtn.onClick.AddListener (() => { GameController.instance.StartGame(); });
    }
}
