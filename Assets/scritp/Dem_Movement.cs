using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dem_Movement : MonoBehaviour
{
    Animator myAnim;
    AudioSource aud;
    public AudioClip moveClip;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("state", 0);
        //walking
        if (Input.GetKey(KeyCode.W))
        { myAnim.SetInteger("state", 1);
   
        }
        //jump
        if (Input.GetKey(KeyCode.Space))
        { myAnim.SetInteger("state", 9); }

        //left
        if (Input.GetKey(KeyCode.A))
        { myAnim.SetInteger("state", 7);         
        }
        //right
        if (Input.GetKey(KeyCode.D))
        { myAnim.SetInteger("state", 5);           
        }
        //run
        if (Input.GetKey(KeyCode.LeftShift))
        { myAnim.SetInteger("state", 9); }
        //attack
        if (Input.GetMouseButton(0))
        { myAnim.SetInteger("state", 10); }
        //left_run
        if (Input.GetKey(KeyCode.LeftShift))
        { myAnim.SetInteger("state", 11); }
        //right_run
        if (Input.GetKey(KeyCode.LeftShift))
        { myAnim.SetInteger("state", 13); }

        //right_walkbackwards
        if (Input.GetKey(KeyCode.S))
        { myAnim.SetInteger("state", 17);
      
        }

        //run_walkbackwards
        if (Input.GetKey(KeyCode.LeftShift))
        { myAnim.SetInteger("state", 18); }

        //flex
        if (Input.GetKey(KeyCode.E))
        { myAnim.SetInteger("state", 19); }
        //roar
        if (Input.GetKey(KeyCode.R))
        { myAnim.SetInteger("state", 20);
            aud.PlayOneShot(moveClip);
        }
    }
}


