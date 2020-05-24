using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_Jump : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;
    Rigidbody myRb;
    static Animator myAnim;

    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
        myAnim = GetComponent<Animator>();

    }

    void Update()
    {
        onGround = true;
        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false;
                myAnim.SetInteger("state", 4);

            }
        }    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag
      ("Ground")) { onGround = true; }
    }
}
