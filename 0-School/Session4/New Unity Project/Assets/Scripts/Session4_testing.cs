﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   



    }


    // Update is called once per frame
    void Update()
    {
        //move object up
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(Vector3.up * 0.1f);

        }
        //move object down
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(Vector3.down * 0.1f);

        }
        // check if an object is seeing another object using ray casting
        // get the postion from where we are casting the ray
        Vector3 rayCastPosition = this.gameObject.transform.position;
        // create a ray in the direction way that want to casting
        Vector3 rayCastDirection = this.gameObject.transform.TransformDirection(Vector3.back);
        //create a variable that stores the info about what we are hitting
        RaycastHit objectSeenByRay;
        //cast the ray
        if (Physics.Raycast(rayCastPosition, rayCastDirection, out objectSeenByRay))
        {
            Debug.Log("Object seen:" + objectSeenByRay.transform.name);
            Debug.Log("Object position:" + objectSeenByRay.transform.ToString());
            Debug.Log("Piont where ray is hitting the object:" + objectSeenByRay.point);
            Destroy(objectSeenByRay.transform.gameObject);
        }

    }
}
