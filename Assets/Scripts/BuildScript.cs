using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildScript : MonoBehaviour
{
    AudioSource audioSource;
    private float hasJoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody>() != null && hasJoint != 2){
            if(gameObject.name == "Collision1" && (collision.collider.name == "Connector" || collision.collider.name == "polySurface1")){
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
                hasJoint = hasJoint + 1;

                if(hasJoint == 2){
                    audioSource.Play();
                }
            }
            if(gameObject.name == "Collision2" && (collision.collider.name == "Connector" || collision.collider.name == "polySurface2")){
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
                hasJoint = hasJoint + 1;

                if(hasJoint == 2){
                    audioSource.Play();
                }
                
            }
            if(gameObject.name == "Collision3" && (collision.collider.name == "Connector" || collision.collider.name == "polySurface3")){
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
                hasJoint = hasJoint + 1;

                if(hasJoint == 2){
                    audioSource.Play();
                }
            }
            if(gameObject.name == "Collision4" && (collision.collider.name == "Connector" || collision.collider.name == "polySurface4")){
                gameObject.AddComponent<FixedJoint>();
                gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
                hasJoint = hasJoint + 1;

                if(hasJoint == 2){
                    audioSource.Play();
                }
            }
        }
    }
}