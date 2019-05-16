using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemushroom : MonoBehaviour
{
    Animator myAnim;
    public Rigidbody myRb;
    
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myRb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("state", 0);

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction, Color.green);

        if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
            && Input.GetKey(KeyCode.W))
        {//walking
            if (hit.transform==transform) { myAnim.SetInteger("state", 10);               
            }
          
        }


        if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
           && Input.GetKey(KeyCode.A))        
            {//left
            if (hit.transform == transform) { myAnim.SetInteger("state", 4); 
            
            }
            }


        if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
        && Input.GetKey(KeyCode.S))
        {//back
            if (hit.transform == transform) { myAnim.SetInteger("state", 3);
            
            }
        }



                if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
           && Input.GetKey(KeyCode.D))                
                    {//right
            if (hit.transform == transform) { myAnim.SetInteger("state", 2); 
            
            }
                    }
                    //Debug.Log("you hit something ..." + hit.transform.gameObject.name);
                }
            }
        
    

                

