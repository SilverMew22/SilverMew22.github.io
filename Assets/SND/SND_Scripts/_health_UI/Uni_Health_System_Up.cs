using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uni_Health_System_Up : MonoBehaviour
{
    public static float U_health = 100f;
    public GameObject Uni;
    public GameObject clone;
    public Vector3 spawnLocation_cas;
    public Vector3 spawnLocation_ground;
    public Image healthBar;
    float timer = 20f;


    void Update()
    {
        healthBar.fillAmount = U_health / 100;

        if (U_health <= 0f)
        {
            //Destroy(gameObject);
           // U_health_Drained();
           // healthBar.fillAmount = timer += Time.deltaTime/100f;
            Uni.GetComponent<Animator>().SetTrigger("isCon");
        }

    if (timer >= 0f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            //run your  code
            timer = 20f;
        }
    }




    void U_health_Drained() {
        //Instantiate(clone, spawnLocation_cas, Quaternion.identity);
        //U_health = timer += Time.deltaTime;
        healthBar.fillAmount += Time.deltaTime/1f;

        if (U_health >= 0f) {
            U_health = 0;                      
            //Destroy(gameObject);
            //Instantiate(clone, spawnLocation_ground, Quaternion.identity);
            Uni.GetComponent<Animator>().SetTrigger("isCon");

        }                      
        }        
    
}
