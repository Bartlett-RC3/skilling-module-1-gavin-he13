using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session4 : MonoBehaviour
{
    //variables 
    public GameObject cubePrefab;
   

    // Start is called before the first frame update
    void Start()
    {

        //calling  or using a corouutine
        StartCoroutine(cubeColorChange());
    }

    // Update is called once per frame
    
    //coroutines
    IEnumerator cubeColorChange()
    {
        
      for (int i = 0; i < 20; i++)
        {
            yield return new WaitForSeconds(1f);
            Vector3 Position = new Vector3(Random.Range(-5.0f, 12.0f), Random.Range(3.0f, 14.0f), Random.Range(-7.0f, 6.0f));
            Quaternion Rotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            GameObject cubePrefabC = Instantiate(cubePrefab, Position, Rotation);
            cubePrefabC.GetComponent<Renderer>().material.color = color;
        }
       
    }
}
