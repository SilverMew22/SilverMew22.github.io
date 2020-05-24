using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DS_Follow_Nova : MonoBehaviour
{

    public Transform prey;
    Vector3 targetPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(prey.position.x, transform.position.y, prey.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 4 * Time.deltaTime);
    }
}
