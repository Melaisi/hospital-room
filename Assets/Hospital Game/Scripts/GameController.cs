using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

/// <summary>
/// Keep track of game state and allow other component to watch for state change 
/// </summary>
public class GameController : MonoBehaviour
{
    public static GameController instance; 
    public enum State { PreGame ,Playing, Pause, End, Quit}

    [SerializeField]
    private State currentGameState;

    [SerializeField]
    private State previousGameState;

    public UnityAction<State, State> onGameStateChange;

    

    // singlton 
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            currentGameState = State.PreGame;
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        onGameStateChange += (State from, State to) =>
        {
            Debug.Log($"Game state change from {from.ToString()} to {to.ToString()}");
        };
    }

    private void UpdateState(State to)
    {
        previousGameState = currentGameState;
        currentGameState = to;

        // invoke actions to subscriber 
        onGameStateChange(previousGameState, currentGameState);
    }

    public void StartGame()
    {
        UpdateState(State.Playing);
    }
    public void RestartGame()
    {
        UpdateState(State.PreGame);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        UpdateState(State.Pause);
    }

    public void EndGame()
    {
        UpdateState(State.End);
    }

    public void QuitGame()
    {
        UpdateState(State.Quit);
    }

}
