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
        // test shuffle 
        Debug.Log(items.ToString());
       
    }

    
}
