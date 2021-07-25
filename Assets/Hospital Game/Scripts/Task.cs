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
        Shuffle<GameObject>(items);
        // test shuffle 
        Debug.Log(items.ToString());
       
    }

    
    private void Shuffle<T> (IList<T> list)
    {
        
        for (int i = list.Count-1; i > 0;  i--)
        {
            int random = Random.Range(0, i);
            T val = list[i];
            list[i] = list[random];
            list[random] = val;
        }
    }
}
