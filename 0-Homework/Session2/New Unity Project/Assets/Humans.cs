using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3_Humans;


public class Humans : MonoBehaviour
{
    // Start is called before the first frame update
    //variables
    Human_Class superman, batman, aquarman;
    Cyborg supermanCyborg;


    void Start()
    {
        superman = new Human_Class("superman", 1.88f);
        batman = new Human_Class("batman", 1.89f);
        aquarman = new Human_Class("aquarman", 1.90f);
        supermanCyborg = new Cyborg("Cy0c", 1.74f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(superman.GetName());
        superman.Running();
        superman.WorkOut();
     
        
       
    }
   
 
}
