using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction, Color.green);

        if (Physics.Raycast(laser, out hit, 1000f) && Input.GetMouseButton(0) && (Input.GetKeyDown(KeyCode.M)))
            {if (hit.transform == transform) { Instantiate(clone, spawnLocation, Quaternion.identity); }
        }
    } }


