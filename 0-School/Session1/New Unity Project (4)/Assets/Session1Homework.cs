using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{
    //1.variables
    //Numbers
    public int MyFirstWholeNumber = 1;
    public int MySecondWholeNumber = 99;

    public float MyFirstDecimalNumber = 1.123456f;
    public double myFirstLongDecimalNumber = 1.123456d;

    public string myFirstWords = "hello";
    public bool myFirstBoolean = true;
    private bool mySecondBoolean = true;

    public string mySecondWord = "HELLO";
    //2.Data Structures
    public int[] myWholeNumbersCollection = new int[4];
    public float[] myDecimalNumbersCollection = { 1.3f, 2.5f, 3.0f };

    
    //array that just for type of int.
    public List<int> myFirstIntList = new List<int>();

    //functions
    private float CalculatorSum(float _FirstNumber, float _SecondNumber)
    {
        float SumResult = _FirstNumber + _SecondNumber;
        return SumResult;

    }
    // Start is called before the first frame update
    void Start()
    {
        float SumResult = CalculatorSum(MyFirstWholeNumber, MySecondWholeNumber);
        Debug.Log("Adding two numbers result is:" + SumResult.ToString());


        //Data Arrays
        //Changing the data
        myDecimalNumbersCollection[0] = 2.8f;
        //retriving data
        float SumResult2 = CalculatorSum (myDecimalNumbersCollection[0], myDecimalNumbersCollection[2]);

        //add data in lists
        myFirstIntList.Add(3);
        myFirstIntList.Add(9);
        myFirstIntList[0] = 5;
        myFirstIntList[1] = 12;
        //retriving data
        Debug.Log(myFirstIntList[0]);

    }


    // Update is called once per frame
   

 
    
    void Update()
    {
   

    }

}
