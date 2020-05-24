using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    //Rigidbody knightRB;
    //public Transform cas;
    //public float forceAmt;
    //public float distThrest;

    public int knightsKilled;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova") && Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Nova hit you.");
            Destroy(gameObject);
            knightsKilled++;
            keepScore.Score += 001;
        }
    }
}
