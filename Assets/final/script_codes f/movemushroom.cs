using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemushroom : MonoBehaviour
{
    Animator myAnim;
    public Rigidbody myRb;
    public float boom_Amt;
    public GameObject[] mushMans;
    public float multiplier = 10f;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myRb = GetComponent<Rigidbody>();
        mushMans = GameObject.FindGameObjectsWithTag("mushMan");
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
            myAnim.SetInteger("state", 1);
            //myRb.AddForce(new Vector3(-1f, 0f, 0f) * multiplier);
        }


        if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
           && Input.GetKey(KeyCode.A))        
            {//left
                myAnim.SetInteger("state", 4);
            }


            if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
            && Input.GetKey(KeyCode.S))            
                {//back
                    myAnim.SetInteger("state", 3);}



                if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0)
           && Input.GetKey(KeyCode.D))                
                    {//right
                        myAnim.SetInteger("state", 2);
                    }
                    Debug.Log("you hit something ..." + hit.transform.gameObject.name);
                }
            }
        
    

                

