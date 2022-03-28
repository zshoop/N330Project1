using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{

    Animator m_Animator;

    public GameObject Claw;
    public Transform dest;
    private GameObject grabbed = null;

    private bool open;
    private bool close;
    private bool opening;
    private bool closing;
    private bool firstOpen = false;
    private bool pickup;
    private bool set;
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
            // if(waitTime > 0 && open == false){
            //     opening = true;
            //     waitTime -= Time.deltaTime;
            // }
            // if(waitTime == 0){
            open = true;
            close = false;
            pickup = false;
            // opening = false;
            // }
            // firstOpen = true;
        }

        //close the claw
        if(Input.GetKey(KeyCode.LeftShift)){
            m_Animator.ResetTrigger("Open");
            m_Animator.SetTrigger("Close");
            // if(waitTime > 0 && open == true){
            //     closing = true;
            //     waitTime -= Time.deltaTime;
            // }
            // if(waitTime == 0){
            open = false;
            close = true;
            // closing = false;            
            // }
        }

        //check if an item has been picked up
        if(pickup == true){
                grabbed.GetComponent<MeshCollider>().enabled = false;
                grabbed.GetComponent<Rigidbody>().useGravity = false;
                grabbed.transform.position = dest.position;
                grabbed.transform.parent = GameObject.Find("GrabDest").transform;
        }

        if(pickup == false){
            grabbed.transform.parent = null;
            grabbed.GetComponent<Rigidbody>().useGravity = true;
            grabbed.GetComponent<MeshCollider>().enabled = true;
            grabbed = null;
        }
    }

    public void SetParent(GameObject newParent)
    {
        newParent.GetComponent<MeshCollider>().enabled = false;
        newParent.GetComponent<Rigidbody>().useGravity = false;
        newParent.transform.position = dest.position;
        newParent.transform.parent = GameObject.Find("GrabDest").transform;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(close == true && grabbed == null){
            if(collision.collider.tag == "Piece" && pickup == false){
                // grabbed = collision.gameObject;
                // grabbed.GetComponent<MeshCollider>().enabled = false;
                // grabbed.GetComponent<Rigidbody>().useGravity = false;
                // grabbed.transform.position = dest.position;
                // grabbed.transform.parent = GameObject.Find("GrabDest").transform;
                grabbed = collision.gameObject;
                pickup = true;
                // gameObject.AddComponent<FixedJoint>();
                // gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
            }
        }
        if(open == true && grabbed != null){
            // collision.gameObject.transform.parent = null;
            // collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            // collision.gameObject.GetComponent<MeshCollider>().enabled = true;
            set = true;
            pickup = false;
            // Destroy(gameObject.GetComponent<FixedJoint>());
        }
    }
}
