using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions 
{

    public static void Shuffle<T>(this IList<T> list)
    {

        for (int i = list.Count - 1; i > 0; i--)
        {
            int random = Random.Range(0, i);
            T val = list[i];
            list[i] = list[random];
            list[random] = val;
        }
    }
}
