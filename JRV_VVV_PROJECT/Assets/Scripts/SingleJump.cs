using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SingleJump : MonoBehaviour
{
   public float jumpForce = 5;
   public float groundDistance = 0.5f;

   Rigidbody RigidBody;

   void Awake()
   {
        RigidBody = GetComponent<Rigidbody>();

   }

   bool isGrounded()
   {
        return Physics.Raycast(transform.position, Vector3.down, groundDistance);
   }

   void Update()
   {
        if(isGrounded()) // && Input.GetMouseButtonDown(0) PARA SALTAR COM BUTAO
        {
            RigidBody.velocity = Vector3.up * jumpForce;
        }
        
   }

}
