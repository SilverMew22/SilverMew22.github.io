using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform Nova;
    


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Nova"))
        {
            Player_Manager.health += 40;
            Uni_Health_System_Up.U_health -= 10;
            Fire_duration.fire_health += 40;
            Debug.Log("Uni healed Nova.");
            Castle_Health_System.Cas_health += 20;
        }
        if (col.gameObject.CompareTag("Castle"))
        {
            Debug.Log("Unicorn is on the castle.");
           
            print(transform.localPosition.y);
            
        }

    }
   
    
}
    

       

