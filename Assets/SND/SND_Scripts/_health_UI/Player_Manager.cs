using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Manager : MonoBehaviour
{
    public static float health = 100;
    public GameObject player;
    public GameObject player_ani;
    public Image healthBar;
    public GameObject sparkle;
    //public Scene scene;

    void Start()
    {
        //scene = SceneManager.GetActiveScene();
        //if (health <= 0) {Restart(); }
    }

    void Update()
    {
        healthBar.fillAmount = health / 100;
        if (health <= 0)
        {
            player.GetComponent<Animator>().SetTrigger("isDead");
            player_ani.SetActive(false);
            sparkle.SetActive(true);
            //player.SetActive(false);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Application.LoadLevel(scene.name);
        }

        if (Fire_duration.fire_health <= 0)
        {
            sparkle.SetActive(true);
            healthBar.fillAmount = health / 20;
        }
        
    }
    
        
    } 

   
