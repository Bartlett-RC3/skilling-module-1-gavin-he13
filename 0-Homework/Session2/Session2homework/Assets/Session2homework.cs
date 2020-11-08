using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2homework : MonoBehaviour
{
    //drink names array
    string[] drinks = { "Cola", "Sprit", "Fanta", "Seven-up" };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(drinks[1]);
        //for loop
        for (int counter = 0; counter < drinks.Length; counter = counter + 1)
        {
            Debug.Log("The current drink is at position" + counter);
            Debug.Log(" " + drinks[counter]);
        }
        // Asking Multiple questions(function with condition)
        bool ColaIsHealth = false;
        bool MilkIsHealth = true;
        bool WineIsHealth = false;

        //two conditions met(Concatenation)
        if (ColaIsHealth && WineIsHealth)
        {
            Debug.Log("Both answers are true");


        }
        //more than 2questions
        if (ColaIsHealth || MilkIsHealth || WineIsHealth)
        {
            Debug.Log("Both answers are false");

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
