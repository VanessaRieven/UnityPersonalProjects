using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script muda material do chao on collision
public class BoxTrigger : MonoBehaviour
{
    public Renderer rend;
    GameObject player1;
    public bool player1Entered = false;
    GameObject player2;
    public bool player2Entered = false;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        player1 = GameObject.FindGameObjectWithTag("Player");
        player1 = GameObject.FindGameObjectWithTag("Player2");
    }

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "Player"){
            player1Entered = true;
        }else if(obj.tag == "Player2"){
            player2Entered = true;
        }
    }
}
