using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "Player"){
            rend.material.color = Color.red;
        }else if(obj.tag == "Player2"){
            rend.material.color = Color.blue;
        }
    }
}
