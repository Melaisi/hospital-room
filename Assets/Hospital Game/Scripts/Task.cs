using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public List<GameObject> itemsPrefab = new List<GameObject>();
    public List<GameObject> items = new List<GameObject>();
    public List<Transform> startingLocation = new List<Transform>();
    public List<Transform> endLocation = new List<Transform>();

    int itemsInEndLocation = 0;

    private void Start()
    {
        initializeItems();
    }

    private void initializeItems()
    {
        // instantiate items randomly
        // shuffle items
        // items.Shuffle();
        // shuffle starting position instead 
        startingLocation.Shuffle();
        // instantiate items to starting location  
        // todo: make sure avaliable starting locations 
        for (int i=0; i< itemsPrefab.Count; i++)
        {
            var item = Instantiate(itemsPrefab[i], startingLocation[i].position, itemsPrefab[i].transform.rotation);
            // assign end location 
            item.GetComponent<Item>().endLocation = endLocation[i].gameObject;
            // assign this task to each item 
            item.GetComponent<Item>().task = this;
            // add item ref to items list 
            items.Add(item.gameObject);
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
    
    // to be called be called by ItemMovment everytime an item inter or exist [should be static somewhere for easy access] 
    public void increaseItemsInEndLocation()
    {
        itemsInEndLocation++;

        // check if all items in their end location then calculate the score and end the game 
        if (items.Count == itemsInEndLocation)
        {
            validate();
        }
    }

    public void decreaseItemsInEndLocation()
    {
        if(itemsInEndLocation > 0)
        {
            itemsInEndLocation--; 
        }
    }
}
