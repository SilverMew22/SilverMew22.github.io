using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject help;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        { help.SetActive(true); }

        if ( !Input.GetKey(KeyCode.Q))

        {
            help.SetActive(false);
        }
    }
}
    


