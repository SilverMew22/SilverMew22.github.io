using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bring_the_Slayer : MonoBehaviour
{
    public GameObject DS;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Player_Manager.health <= 0 || Castle_Health_System.Cas_health <= 0)
        //{ DS.SetActive(false); }

        if (keepScore.Score <= 25) 

        {
            DS.SetActive(true);
        }
        //else if (keepScore.Score >= 35) {DS.SetActive(false); }
             
    }
    
    }
    

    


