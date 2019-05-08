<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class myNav_agent : MonoBehaviour
{
    NavMeshAgent nav;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = target.position;
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("your trigger hit..." + other.name);
        if (other.gameObject.CompareTag("Prey"));
        { nav.destination=other.transform.position; }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class myNav_agent : MonoBehaviour
{
    NavMeshAgent nav;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = target.position;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"));
        { nav.destination=other.transform.position; }
    }
}
>>>>>>> 56d34f83017438743a4a4ff1800e67d0b9f9daeb
