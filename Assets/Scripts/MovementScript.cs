using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    private Vector3 PlayerMovementInput;

    public Rigidbody PlayerBody;
    public Rigidbody rClaw;
    public Rigidbody lClaw;

    public float Speed = 2;
    public float Jumpforce = 0;


    // Update is called once per frame
    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);

        if(Input.GetKeyDown(KeyCode.Space)){
            Jumpforce = 5;
            PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }

        if(!Input.GetKeyDown(KeyCode.Space)){
            Jumpforce = 0;
            PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.LeftShift)){
            Jumpforce = -3;
            PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }
    }
}
