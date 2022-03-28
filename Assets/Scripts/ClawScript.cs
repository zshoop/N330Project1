using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{

    Animator m_Animator;

    public GameObject Claw;
    public Transform dest;
    private GameObject grabbed;

    private bool open;
    private bool close;
    private bool pickup;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //open the claw
        if(Input.GetKey(KeyCode.Mouse0)){
            m_Animator.ResetTrigger("Close");
            m_Animator.SetTrigger("Open");
            open = true;
            close = false;
            pickup = false;
        }

        //close the claw
        if(Input.GetKey(KeyCode.Mouse1)){
            m_Animator.ResetTrigger("Open");
            m_Animator.SetTrigger("Close");
            open = false;
            close = true;
        }

        //check if an item has been picked up
        if(pickup == true){
            //disable collider
            grabbed.GetComponent<MeshCollider>().enabled = false;
            //disable gravity
            grabbed.GetComponent<Rigidbody>().useGravity = false;
            //set position to claw
            grabbed.transform.position = dest.position;
            //set transform parent so position moves with claw
            grabbed.transform.parent = GameObject.Find("GrabDest").transform;
        }

        //check if an item is not being picked up
        if(pickup == false && grabbed != null){
            //remove the transform parent
            grabbed.transform.parent = null;
            //enable gravity
            grabbed.GetComponent<Rigidbody>().useGravity = true;
            //enable collider
            grabbed.GetComponent<MeshCollider>().enabled = true;
            //set grabbed gameobject to null so it no longer remains tied to the claw in any way; until another object is picked up
            grabbed = null;
        }
    }

    //completely unneccessary function that does literally nothing right now, I just kept it in for funsies
    public void SetParent(GameObject newParent)
    {
        newParent.GetComponent<MeshCollider>().enabled = false;
        newParent.GetComponent<Rigidbody>().useGravity = false;
        newParent.transform.position = dest.position;
        newParent.transform.parent = GameObject.Find("GrabDest").transform;
    }

    //collision function
    void OnCollisionEnter(Collision collision)
    {
        //if the claw is closed and there are no grabbed objects
        if(close == true && grabbed == null){
            //if the collision detects a "Piece" and pickup is false: set the grabbed gameobject to the collision and pickup to true
            if(collision.collider.tag == "Piece" && pickup == false){
                grabbed = collision.gameObject;
                pickup = true;
            }
        }
        //if the claw is open and the grabbed object is not null: set pickup to false
        if(open == true && grabbed != null){
            pickup = false;
        }
    }
}
