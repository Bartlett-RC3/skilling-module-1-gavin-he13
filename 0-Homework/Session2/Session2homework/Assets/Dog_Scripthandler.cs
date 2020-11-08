using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doggie_Class;

public class Dog_Scripthandler : MonoBehaviour
{
    // Start is called before the first frame update
    //variables
    Dog_Class Barbert, Beagle, Boxador;
    Cyber_Doggie BarbertCyber;


    void Start()
    {
        Barbert = new Dog_Class("Barbert", 1.2f,50f);
        Beagle = new Dog_Class("Beagle", 1.89f,40f);
        Boxador = new Dog_Class("Boxador", 1.90f,30f);
        BarbertCyber = new Cyber_Doggie("BIBI", 1.2f,50f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Barbert.GetName());
        Barbert.Running();
        Barbert.Sleep();



    }


}
