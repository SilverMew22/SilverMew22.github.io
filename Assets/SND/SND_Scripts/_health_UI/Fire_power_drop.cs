using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_power_drop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (Input.GetButton("Jump"))
        {
            Debug.Log("You used your fire");
            Fire_duration.fire_health --;


        }
        else { Fire_duration.fire_health ++; }
    }
}

