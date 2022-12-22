using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{

    public GameObject Winner;
    

    void Start()
    {
        Instantiate(Winner, transform.position, transform.rotation);
    }
}
