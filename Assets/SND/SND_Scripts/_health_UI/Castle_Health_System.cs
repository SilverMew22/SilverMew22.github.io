using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle_Health_System : MonoBehaviour
{
    public static float Cas_health = 100;
    public GameObject Cas;
    public Image healthBar;

    void Update()
    {
        healthBar.fillAmount = Cas_health / 100; 

    }

    public void IncreaseHealth(int value)
    {
        Cas_health += value;

    }

    public void DecreaseHealth(int value)
    {
        Cas_health -= value;

    }
}