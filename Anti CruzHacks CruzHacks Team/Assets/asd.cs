using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    private Vector3 moveDirection = Vector2.zero;
    public float gravity = 20.0f;
    CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    { 
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded) {
             //Feed moveDirection with input.
             moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
             moveDirection = transform.TransformDirection(moveDirection);
             //Multiply it by speed.
             moveDirection *= speed;
             //Jumping
             if (Input.GetButton("Jump"))
                 moveDirection.y = jumpSpeed;
             
         }
         //Applying gravity to the controller
         moveDirection.z -= gravity * Time.deltaTime;
         //Making the character move
         controller.Move(moveDirection * Time.deltaTime);
    }
}
