using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 PlayerMovementInput;
    //private Vector2 PlayerMouseInput;

    [SerializeField] private Rigidbody PlayerBody;
    [SerializeField] private float Speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float jumpY;
    [SerializeField] private bool isGrounded;

    private void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            PlayerBody.AddForce(new Vector3(0, jumpY, 0) * jumpForce);
            Debug.Log("Is jumping");
        }
    }

    public void MovePlayer()
    {
        //Calculate movement dir
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
    } 
}
