using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3HOMEWORK : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject cube;
    public int numberOfCubes = 1;
    public float spacing = 2.0f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    private int frameCount = 0;

    void Start()
    {
        //communicate between script and the editor/Add a script to a game object
        Debug.Log("Message");
        Debug.Log(Time.deltaTime);
        //creat a cube
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spacing, 1, 1);
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
        for (int i = 0; i < cubeCopies.Count; i++)
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

        //Create a cube and move it across the screen
        foreach (GameObject cubeCopy in cubeCopies)
        {
            Vector3 moveCopy = new Vector3(Random.Range(0.0f, 0.25f),0 , 0);
            cubeCopy.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

        }

        //Create a cube and change its colour when key is pressed or mouse is pressed
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
