<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;

    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (onGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag
      ("Ground")) { onGround = true; }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;

    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (onGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag
      ("Ground")) { onGround = true; }
    }
}
>>>>>>> 56d34f83017438743a4a4ff1800e67d0b9f9daeb
