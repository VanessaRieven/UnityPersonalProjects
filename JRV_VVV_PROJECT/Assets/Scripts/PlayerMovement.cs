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
    ColectColor colectColorScript;

    public Rigidbody rb;
    public float m_Speed = 10.0f;
    //countdown true and Go!
    public Countdown CountdownScript;

    private void Start()
    {
        colectColorScript = GameObject.FindGameObjectWithTag("Floor").GetComponent<ColectColor>(); //vai buscar o collectColor script a pasta
        CountdownScript.TimerOn = false;
    }

    void Update()
    {
        if(CountdownScript.TimerOn)
        {
            if (transform.position.x > -4)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    transform.eulerAngles = LeftTurn;
                    Anim.Play("Jump");
                }
            }
            if (transform.position.x < 1)
            {
                if (Input.GetKey(KeyCode.D))
                {
                    transform.eulerAngles = RightTurn;
                    Anim.Play("Jump");
                }
            }
            if (transform.position.z < 1)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    transform.eulerAngles = UpTurn;
                    Anim.Play("Jump");
                }
            }
            if (transform.position.z > -4)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    transform.eulerAngles = DownTurn;
                    Anim.Play("Jump");
                }
            }
        }
    }

    public void Move(){
        rb.velocity = transform.forward * m_Speed;
    }

}
