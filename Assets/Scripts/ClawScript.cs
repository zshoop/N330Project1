using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{

    Animator m_Animator;

    private bool open;
    private bool opening;
    private bool closing;
    private bool firstOpen = false;
    private float waitTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //open the claw
        if(Input.GetKey(KeyCode.RightShift)){
            m_Animator.ResetTrigger("Close");
            m_Animator.SetTrigger("Open");
            if(waitTime > 0 && open == false){
                opening = true;
                waitTime -= Time.deltaTime;
            }
            if(waitTime == 0){
            open = true;
            opening = false;
            }
            firstOpen = true;

        }

        //close the claw
        if(Input.GetKey(KeyCode.LeftShift)){
            m_Animator.ResetTrigger("Open");
            m_Animator.SetTrigger("Close");
            if(waitTime > 0 && open == true){
                closing = true;
                waitTime -= Time.deltaTime;
            }
            if(waitTime == 0){
            open = false;
            closing = false;            
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody>() != null && closing == true){
            if(collision.collider.tag == "Piece"){
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
            }
        }
        if(opening == true && firstOpen == true){
            Destroy(gameObject.GetComponent<FixedJoint>());
        }
    }
}
