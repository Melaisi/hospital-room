using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject endLocation;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndLocation")
        {
            if(other.gameObject == endLocation)
            {
                Debug.Log("Correct location enter");
            }
            else
            {
                Debug.Log("Wrong location enter");
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndLocation")
        {
            if (other.gameObject == endLocation)
            {
                Debug.Log("Correct location exit");
            }
            else
            {
                Debug.Log("Wrong location exit");
            }
        }
    }
}
