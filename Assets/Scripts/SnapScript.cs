using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapScript : MonoBehaviour
{

    public GameObject gm;

    AudioSource audioSource;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        if(gameObject.name == "placement1" && collision.gameObject.name == "polySurface1"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.0193f, 0.4f, -0.0554f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
        if(gameObject.name == "placement2" && collision.gameObject.name == "polySurface2"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.0215f, 0.4f, -0.0507f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
        if(gameObject.name == "placement3" && collision.gameObject.name == "polySurface3"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.0176f, 0.4f, -0.0506f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
        if(gameObject.name == "placement4" && collision.gameObject.name == "polySurface4"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.0144f, 0.4f, -0.0516f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }

        if(gameObject.name == "placement5" && collision.gameObject.name == "Phone_bottom"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.1296f, 0.4f, -0.0033f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
        if(gameObject.name == "placement5" && collision.gameObject.name == "Phone_middle"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.1296f, 0.4f, -0.0033f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
        if(gameObject.name == "placement5" && collision.gameObject.name == "Phone_battery"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.1296f, 0.4f, -0.0033f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
        if(gameObject.name == "placement5" && collision.gameObject.name == "Phone_top"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.1296f, 0.4f, -0.0033f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }

        if(gameObject.name == "placement6" && collision.gameObject.name == "chair_legs1"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.035f, 0.7f, 0.0f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }

        if(gameObject.name == "placement7" && collision.gameObject.name == "chair_legs2"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.15f, 0.7f, 0.0f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }

        if(gameObject.name == "placement8" && collision.gameObject.name == "chair_crossbeam"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 90);
            collision.gameObject.transform.position = new Vector3(0.1296f, 0.7f, -0.35f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }

        if(gameObject.name == "placement9" && collision.gameObject.name == "chair_seat"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.1296f, 0.7f, -0.0033f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }

        if(gameObject.name == "placement10" && collision.gameObject.name == "chair_back"){
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<MeshCollider>().enabled = false;
            collision.gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
            collision.gameObject.transform.position = new Vector3(0.095f, 1.5f, .3f);
            collision.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

            audioSource.Play();
            score = score + 1;
        }
    }
}
