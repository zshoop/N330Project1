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
    // public float timeSpan = 0.3f;
    // private float time;
    // private float smooth = 90f;
    // private float rTiltAngle = 0f;
    // private bool open = false;


    // Update is called once per frame
    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();
        // openClaw();
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

        if(Input.GetKeyDown(KeyCode.Tab)){
            Jumpforce = -3;
            PlayerBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse);
        }
    }

    // private void openClaw()
    // {
    //     Quaternion rTarget = Quaternion.Euler(0, -30, 0);
    //     Quaternion lTarget = Quaternion.Euler(0, 30, 0);
    //     Quaternion rClose = Quaternion.Euler(0, 30, 0);
    //     Quaternion lClose = Quaternion.Euler(0, -30, 0);

    //     if(Input.GetKeyDown(KeyCode.RightShift) && !open){
    //     rClaw.transform.rotation = Quaternion.Slerp(rClaw.transform.rotation, rTarget, .3f);
    //     lClaw.transform.rotation = Quaternion.Slerp(lClaw.transform.rotation, lTarget, .3f);
    //     open = true;
    //     }

    //     if(Input.GetKeyDown(KeyCode.LeftShift) && open){
    //     rClaw.transform.rotation = Quaternion.Slerp(rClaw.transform.rotation, rClose, .3f);
    //     lClaw.transform.rotation = Quaternion.Slerp(lClaw.transform.rotation, lClose, .3f);
    //     open = false;
    //     }
    // }
}
