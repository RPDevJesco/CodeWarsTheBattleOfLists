# CodeWarsTheBattleOfLists
The code for the video https://www.youtube.com/watch?v=sF0qsYBXeFc&amp;t=5s


In order to get this code to work with Unity3D, there is a slight change you need to make for the Lists.

This is how your shuffledResults class should look.
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShuffledResultClass
{
    public List<GameObject> ShuffledResults(List<GameObject> main, List<GameObject> secondary)
    {
        GameObject[] arr = main.ToArray();
        TheShuffleClass.Shuffle(arr);
        var converted = arr.Distinct().ToList();

        foreach (var item in converted)
            secondary.Add(item);

        return secondary;
    }
}

Then for the class that implements Monobehavior, it should look something like this for the basics...

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviorScripting : MonoBehaviour
{

    public List<GameObject> main;
    List<GameObject> secondary;
    
    void Start ()
    {
        ShuffledResultClass shuff = new ShuffledResultClass();
        shuff.ShuffledResults(main, secondary);

        for (int i = 0; i < secondary.Count; i++)
            Instantiate(secondary[i] as GameObject);
    }
}
