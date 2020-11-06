using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Session1homwork : MonoBehaviour
{


    //Declare a int variable and set a value
    public int MyFirstWholeNumber = 1;
    public int MySecondWholeNumber = 65;
    //Declare a float variable and set a value
    public float MyFirstDecimalNumber = 2.66666f;
    //Declare a string variable and set a value
    public string myFirstWords = "was geht";
    //Create a function that prints the declared variables



    //initialize the function
    public float CalculatorSum(float _FirstNumber, float _SecondNumber)
    {
        float SumResult = _FirstNumber + _SecondNumber;
        return SumResult;

    }
    //Declare and initialize an array  
    public int[] myWholeNumbersCollection = new int[4] { 0, 2, 4, 6 } ;
    
    public float[] myDecimalNumbersCollection = { 6.6f, 7.7f, 8.8f };
    // initialize and Declare an list
    public List<int> myFirstIntList = new List<int>();


    // Start is called before the first frame update
    void Start()
    {
        //print functions
        Debug.Log(CalculatorSum(MyFirstWholeNumber, MySecondWholeNumber));

        //Create and initialize a Dictionary
        
        Dictionary<string, string> Xman = new Dictionary<string, string>();

        //add data
        Xman.Add("Superman", "50");
        Xman.Add("Batman", "50");
        Xman.Add("Deadpool", "50");

        //select data
        Debug.Log(Xman["Deadpool"]);
        //count the length of data
        Debug.Log(Xman.Count);
        //remove selected data
        Debug.Log("Superman");
        //change the data name
        Xman["Deadpool"] = "Jackson";

        //foreach loop
        foreach (var item in Xman)
        {
            Debug.Log(item.Key + "" + item.Value);

        }
        //search for data
        bool isContains = Xman.ContainsValue("Batman");

        //take key 
        ICollection<string> keys = Xman.Keys;
        foreach (string key in keys)
        {
            //using key to take value
            string value = Xman[key];
            Debug.Log($"{key}={value}");

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
