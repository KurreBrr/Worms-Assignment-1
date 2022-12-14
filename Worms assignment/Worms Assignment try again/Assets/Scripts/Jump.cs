using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    //Start is called before the first frame update

    private void Start()
    {
        //controller = GetComponent<CharacterController>();
    }

    //Update is called once per frame
    private void Update()
    {
        //isGrounded = controller.isGrounded; 
    }
    //recieve the inputs for our InputManager.cs and apply them to our character controller.

    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.y = input.y;
        //controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -2f;
        //controller.Move(playerVelocity * Time.deltaTime);
        Debug.Log(playerVelocity);
    }

    /*public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3f * gravity);
        }
    }*/
    
}
