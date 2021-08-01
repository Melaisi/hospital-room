using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_GameState : MonoBehaviour
{


    // change game state by pressing 1 to 5 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            GameController.instance.RestartGame();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameController.instance.StartGame();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameController.instance.PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameController.instance.EndGame();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GameController.instance.QuitGame();
        }
    }
}
