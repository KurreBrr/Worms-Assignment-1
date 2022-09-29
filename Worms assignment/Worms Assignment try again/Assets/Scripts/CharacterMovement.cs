using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 PlayerMovementInput;
    //private Vector2 PlayerMouseInput;

    [SerializeField] private Rigidbody PlayerBody;
    [SerializeField] private float Speed;

    private void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();

    }

    public void MovePlayer()
    {
        //Calculate movement dir
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
    } 
}
