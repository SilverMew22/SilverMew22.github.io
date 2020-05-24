using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Game : MonoBehaviour
{
    public GameObject knight;
    public GameObject objectToDisable;
    public static bool disabled = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player_Manager.health <= 0 || Castle_Health_System.Cas_health <= 0)
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
