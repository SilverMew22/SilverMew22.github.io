﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destry_knights : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Castle"))
        {
            Debug.Log("knight erased");
            Destroy(gameObject);
           

        }
    }
}
