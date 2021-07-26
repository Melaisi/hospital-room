using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public List<Transform> startingLocation = new List<Transform>();
    public List<Transform> endLocation = new List<Transform>();

    

    private void Start()
    {
        initializeItems();
    }

    private void initializeItems()
    {
        // instantiate items randomly
        // shuffle items
        //items.Shuffle();
        // shuffle starting position instead 
        startingLocation.Shuffle();
        // instantiate items to starting location  
        // todo: make sure avaliable starting locations 
        for (int i=0; i<items.Count; i++)
        {
            var item = Instantiate(items[i], startingLocation[i].position,items[i].transform.rotation);
            //assign end location 
            item.GetComponent<Item>().endLocation = endLocation[i].gameObject;

        }
       
    }


    /// <summary>
    /// check if item are in correct order and update score 
    /// </summary>
    private void validate()
    {
       int score = 0;
       foreach(GameObject item in items)
        {
            if (item.GetComponent<Item>().itemInPlace)
            {
                score++;
            }
        }
        Debug.Log("Score:" + score);

    }
    
}
