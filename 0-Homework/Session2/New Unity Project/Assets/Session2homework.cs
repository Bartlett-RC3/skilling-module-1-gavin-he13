 //LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CLASS(es)
public class Session2homework : MonoBehaviour
{
    //colour names array
    string[] colours = { "red", "green", "blue", "white" };
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(colours[1]);
        //loops (initiallize long and steps)
        for(int counter = 0; counter<colours.Length; counter = counter + 1)
        {
            Debug.Log("The current colour is at position" + counter);
            Debug.Log(" "+ colours [counter]);
        }
        //for loop simple
        int sumOfOddNumbers = 0;
        for (int i = 1; i < 100; i = i + 2)
        {
            //sumOfOddNumbers = sumOfOddNumbers + i
            sumOfOddNumbers += i;


        }
        Debug.Log("All Odd numbers to 100 added together is;" + sumOfOddNumbers);
        //shorthand for loop
        foreach(string currentColour in colours)
        {
            Debug.Log("Going over the rainbow with" + currentColour);
        }

        //while loop(needs a condition to end)(continue running until the PC break down)
        int whileCounter = 0;
        string rainbow="Rainbow colours;";
        while (whileCounter < colours.Length)
        {
            rainbow += colours[whileCounter] + ".";
            whileCounter+=2;
        }
        Debug.Log(rainbow);
        //Condtionals(asking pc questions)
        //If  statement 
        for(int i=0;i<100;i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Whole Number;" + i);

            }
            else
            {
                Debug.Log("Odd number" + i);
            }
        }
        // Asking Multiple questions
        bool question1Answer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        //two conditions met(Concatenation)
        if(question1Answer && question2Answer) 
        {
            Debug.Log("Both answers are true");
            

        }
        //one condition is met from 2 questions(Or question)
        if (question1Answer || question3Answer)
        {
            Debug.Log("One of the answer is true");
        }
        //more than 2questions
        if (question1Answer||question2Answer||question3Answer)
        {
            //action here

        }
        //question in question
        if (question1Answer == true)
        {
            if (question2Answer == true)
            {
                if (question3Answer == false)
                {
                    Debug.Log("One of the answer is false");
                }
            }
        }



    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
