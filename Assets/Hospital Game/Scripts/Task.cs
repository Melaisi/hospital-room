using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public List<Transform> startingLocation = new List<Transform>();

    private void Start()
    {
        initializeItems();
    }

    private void initializeItems()
    {
        // instantiate items randomly
        // shuffle items
        items.Shuffle();
        // instantiate items to starting location  
        // todo: make sure avaliable starting locations 
        for (int i=0; i<items.Count; i++)
        {
            Instantiate(items[i], startingLocation[i].position,items[i].transform.rotation);
        }
       
    }

    
}
