using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementExploration : MonoBehaviour
{
    public Animator Anim;
    Vector3 LeftTurn = new Vector3(0,-90f,0);
    Vector3 DownTurn = new Vector3(0, 180f,0);
    Vector3 RightTurn = new Vector3(0,90f,0);
    Vector3 UpTurn = new Vector3(0,0,0);

    public Rigidbody rb;
    public float m_Speed = 10.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            transform.eulerAngles = UpTurn;
            Anim.Play("Jump");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = DownTurn;
            Anim.Play("Jump");
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.eulerAngles = RightTurn;
            Anim.Play("Jump");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.eulerAngles = LeftTurn;
            Anim.Play("Jump");
        }
    }
    public void Move(){
        rb.velocity = transform.forward * m_Speed;
    }

}
