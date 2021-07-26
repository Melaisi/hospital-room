using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemMovment : MonoBehaviour
{
    static bool isHolding = false;
    private void OnMouseDown()
    {
        if (!isHolding)
        {
             // set off gravity 
            gameObject.GetComponent<Rigidbody>().useGravity = false;

            // attached item to as child of camera 
            transform.SetParent(Camera.main.transform);

            isHolding = true;
        }
    }

    private void OnMouseUp()
    {
        if (isHolding)
        {
            // remove item from being attached to a main camera  
            transform.SetParent(null);

            // set gravity back
            gameObject.GetComponent<Rigidbody>().useGravity = true;

            // update flag 
            isHolding = false;
        }
    }
}
