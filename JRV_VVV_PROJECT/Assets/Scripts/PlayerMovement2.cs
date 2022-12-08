using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += (Vector3.left * 2); 
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position +=  (Vector3.right * 2); 
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += (Vector3.forward * 2); 
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += (Vector3.back * 2); 
        }
    }
}
