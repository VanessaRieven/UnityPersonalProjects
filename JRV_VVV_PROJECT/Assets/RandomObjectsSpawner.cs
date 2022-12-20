using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectsSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3((int)Random.Range(-6f, 2f), 1, (int)Random.Range(-6f, 2f)+0.5f);

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            
        }
    }
}
