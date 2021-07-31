using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject endLocation;
    public Task task; 

    public bool itemInPlace = false; // a flag to monitor if an item in the correct place or not. 

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndLocation")
        {
            if(other.gameObject == endLocation)
            {
               itemInPlace = true;
               Debug.Log("Correct location enter");
            }

            // increase task itemsInEndLocation
            task.increaseItemsInEndLocation();

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndLocation")
        {
            if (other.gameObject == endLocation)
            {
                itemInPlace = false;
               // Debug.Log("Correct location exit");
            }
            // decrease task itemsInEndLocation
            task.decreaseItemsInEndLocation();
        }
    }

}
