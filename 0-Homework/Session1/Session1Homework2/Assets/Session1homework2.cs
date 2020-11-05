using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class Session1homework2 : MonoBehaviour
{
    // Start is called before the first frame update
    

    void Start()
    {
        //define key and value
        Dictionary<string, string> Xman= new Dictionary<string, string>();

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
        foreach(string key in keys)
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
