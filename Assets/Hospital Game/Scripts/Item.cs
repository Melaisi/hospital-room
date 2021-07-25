using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject endLocation;

    [SerializeField]
    bool itemInPlace = false; // a flag to monitor if an item in the correct place or not. 

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndLocation")
        {
            if(other.gameObject == endLocation)
            {
               itemInPlace = true;
               Debug.Log("Correct location enter");
            }
            else
            {
               // Debug.Log("Wrong location enter");
            }
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
            else
            {

                //Debug.Log("Wrong location exit");
            }
        }
    }
}
