using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Fire : MonoBehaviour
{
    public GameObject fire;
   

    void Update()
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            fire.SetActive(false);
            
        }
        else {
            fire.SetActive(true);
            
        }

    }

}

