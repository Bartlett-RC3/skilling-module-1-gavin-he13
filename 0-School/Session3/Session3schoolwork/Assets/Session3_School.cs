using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Session3_School : MonoBehaviour
{
    //Variables
    public GameObject cube;
    public int numberOfCubes = 5;
    public float spacing = 2.0f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    private int frameCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Debugging

        //communicate between script and the editor
        Debug.Log("Message");
        Debug.Log(Time.deltaTime);

        try
        {
            cubeCopies[19].transform.Translate(1, 0, 0);

        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
        //create an array of cubes spaced apart
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spacing,1, 1);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy = Instantiate(cube, cubeCopyPosition, cubeCopyRotation);
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubeCopy.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubeCopies.Add(cubeCopy);
        }




    }


    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<cubeCopies.Count; i++)
        {
            GameObject cubeCopy = cubeCopies[i];
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubeCopy.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }

        // time since game started
        Debug.Log("Frames since game started:" + frameCount);
        frameCount++;

        Debug.Log("Unity counted frames:" + Time.frameCount);

        Debug.Log("Unity draws a frame in:" + Time.deltaTime + "seconds");

        //moving !!!
        foreach(GameObject cubeCopy in cubeCopies)
        {
            Vector3 moveCopy = new Vector3(0, Random.Range(0.0f, 0.25f), 0);
            cubeCopy.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

            //rotate
            Vector3 rotateCopy = new Vector3(0, Random.Range(-90.0f, -90.0f), 0);
            cubeCopy.transform.Rotate(rotateCopy);

            //scale
            float scaleAmount = Random.Range(0.5f, 2.0f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            cubeCopy.transform.localScale = scaleCopy;
        }

        //input

        //keyboard input
        if (Input.GetKey(KeyCode.Space))
        {
            foreach(GameObject cubeCopy in cubeCopies)
            {
                float scaleAmount = 2.0f;
                Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
                cubeCopy.transform.localScale = scaleCopy;
            }
        }

        if (Input.GetMouseButton(0))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                Color redColor = new Color(1, 0, 0);
                cubeCopy.GetComponent<MeshRenderer>().material.color = redColor;
            }
        }
    }


}
