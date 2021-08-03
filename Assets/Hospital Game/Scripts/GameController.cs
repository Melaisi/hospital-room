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
    public enum State { MainMenu, PreGame ,Playing, Objective, Pause, Resume, End, Quit}

    [SerializeField]
    private State currentGameState;

    [SerializeField]
    private State previousGameState;

    public UnityAction<State, State> onGameStateChange;

    // score
    // todo: need to make this scalable 
    private int taskScore;
    private int levelScore; 

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
            currentGameState = State.MainMenu;
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        onGameStateChange += (State from, State to) =>
        {
            if(from == State.MainMenu && to == State.PreGame)
            {
                // load main scene 
                SceneManager.LoadScene("Main");
            }
            if(to == State.Quit)
            {
                // load main menu
                SceneManager.LoadScene("MainMenu");
            }
        };
    }

    private void UpdateState(State to)
    {
        previousGameState = currentGameState;
        currentGameState = to;

        // invoke actions to subscriber 
        onGameStateChange(previousGameState, currentGameState);
    }

    public void StartPlaying()
    {

        UpdateState(State.Playing);
    }

    public void StartGame()
    {
        UpdateState(State.PreGame);
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

    public void ShowObjective()
    {
        UpdateState(State.Objective);
    }

    public void EndGame()
    {
        UpdateState(State.End);
    }

    public void QuitGame()
    {
        UpdateState(State.Quit);
    }

    public void ResumeGame()
    {
        UpdateState(State.Resume);
    }
    
    public void setTaskScore(int score)
    {
        taskScore = score;
    }
    public int getTaskScore()
    {
        return taskScore;
    }
    public void setLevelScore(int score)
    {
        levelScore = score;
    }
    public int getLevelScore()
    {
        return levelScore;
    }
}
