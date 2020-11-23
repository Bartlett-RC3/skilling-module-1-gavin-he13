using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour
{
    //variables 
    public GameObject columnPrefab;
    IEnumerator createPrefabsCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        createPrefabsCoroutine = DropPrefabs();
        //calling  or using a corouutine
        StartCoroutine(createPrefabsCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time > 10)
        {
            //stop a specific coroutine
            StopCoroutine(createPrefabsCoroutine);
            //stop all coroutines
            StopAllCoroutines();
        }
    }
    //coroutines
    IEnumerator DropPrefabs()
    {
        while (true)
        {
            //action the coroutines(create and drop the column)
            Vector3 dropPosition = new Vector3(Random.Range(-5.0f, 12.0f), Random.Range(3.0f, 14.0f), Random.Range(-7.0f, 6.0f));
            Quaternion dropRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            Instantiate(columnPrefab, dropPosition, dropRotation);
            yield return new WaitForSeconds(1);
        }



    }

}
