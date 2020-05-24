using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Game : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject knight;
    public static bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (keepScore.Score >= 100)
        {
            if (disabled)
            {
                objectToDisable.SetActive(false);
                knight.SetActive(false);
}
            else
                objectToDisable.SetActive(true);
                knight.SetActive(true);
        }
       

        }
    }

