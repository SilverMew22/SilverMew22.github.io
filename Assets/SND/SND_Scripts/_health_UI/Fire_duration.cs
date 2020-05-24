using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire_duration : MonoBehaviour
{
    public static float fire_health = 100;
    public GameObject fire;
    public Image healthBar;
    float timer = 20f;

    void Update()
    {
        if (timer >= 0f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            //run your  code
            timer = 10f;
        }   

    
        if (Input.GetButton("Jump"))
        {
            //healthBar.fillAmount = fire_health / 100;
            Debug.Log("Fire went down");
            healthBar.fillAmount -= Time.deltaTime / 15f;
        }
        else { healthBar.fillAmount += Time.deltaTime / 10f; }

        //if(healthBar.fillAmount <= 0f)
       // {
         //   Player_Manager.health -= 1f;
       // }
        
    }
     void FixedUpdate()
    {
        if (healthBar.fillAmount <= 0f)
        {
            Player_Manager.health -= 1f;
        }
    }

}





