using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += (Vector3.left * 2); 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position +=  (Vector3.right * 2); 
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += (Vector3.forward * 2); 
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += (Vector3.back * 2); 
        }
    }
}
