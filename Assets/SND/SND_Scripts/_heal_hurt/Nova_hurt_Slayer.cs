using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_hurt_Slayer : MonoBehaviour
{
    public GameObject DS;
    static Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    void Update()
    {
        myAnim.SetInteger("state", 0);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Fire") && Input.GetKey(KeyCode.Space))
        {


        }
        if (col.gameObject.CompareTag("Nova") && !Input.GetKey(KeyCode.Space))
        {
            myAnim.SetInteger("state", 1);

        }
    }
}
