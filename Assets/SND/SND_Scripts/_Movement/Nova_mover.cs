using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_mover : MonoBehaviour
{
    static Animator myAnim;   
    public float multiplier = 10f;
   
    void Start()
    {
        myAnim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {   
            myAnim.SetInteger("state", 1);
        }       
    }    
    }


