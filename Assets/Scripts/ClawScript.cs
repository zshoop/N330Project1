using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawScript : MonoBehaviour
{

    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightShift)){
            m_Animator.ResetTrigger("Close");
            m_Animator.SetTrigger("Open");
        }

        if(Input.GetKey(KeyCode.LeftShift)){
            m_Animator.ResetTrigger("Open");
            m_Animator.SetTrigger("Close");
        }
    }
}
