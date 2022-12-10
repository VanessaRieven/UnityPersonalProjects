using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator Anim;
    Vector3 LeftTurn = new Vector3(0,-90f,0);
    Vector3 DownTurn = new Vector3(0, 180f,0);
    Vector3 RightTurn = new Vector3(0,90f,0);
    Vector3 UpTurn = new Vector3(0,0,0);

    public bool player1Entered = false;
    public bool player2Entered = false;

    public Rigidbody rb;
    public float m_Speed = 10.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = LeftTurn;
            Anim.Play("Jump");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = RightTurn;
            Anim.Play("Jump");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles = UpTurn;
            Anim.Play("Jump");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.eulerAngles = DownTurn;
            Anim.Play("Jump");
        }
    }

    public void Move(){
        rb.velocity = transform.forward * m_Speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.tag == "Player"){
            player1Entered = true;
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
        } else if(this.gameObject.tag == "Player2"){
            player2Entered = true;
        }
    }

    private void ChangeColor(){
        if(player1Entered){
            /* other.material.color = Color.red; */
        }else if(player2Entered){
            /* other.material.color = Color.blue; */
        }
    }

}
