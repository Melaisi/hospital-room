using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Each level maintain a list of tasks, and keep track of score and progress 
/// When all task done, update game controller state 
/// </summary>
public class Level : MonoBehaviour
{

    public List<Task> tasks = new List<Task>();
    private float levelTime = 0f;
    public int score = 0;
    private int noCompletedTasks = 0;
    private bool isLevelCompleted = false; 
    


    private void checkTasksCompilation()
    {
        noCompletedTasks = 0;
        score = 0; // update score from each task
        foreach(Task task in tasks)
        {
            if (task.isTaskDone)
            {
                noCompletedTasks++;
                score += task.score;
            }
        }
        if(noCompletedTasks == tasks.Count)
        {
            isLevelCompleted = true;
            GameController.instance.EndGame();
        }
        else
        {
            isLevelCompleted = false;
        }
    }

    public void increaseNoOfCompleatedTasks()
    {
        noCompletedTasks++;
        if (noCompletedTasks == tasks.Count)
        {
            checkTasksCompilation();
        }
    }

    public void decrreaseNoOfCompleatedTasks()
    {
        noCompletedTasks--;
    }
    
}

