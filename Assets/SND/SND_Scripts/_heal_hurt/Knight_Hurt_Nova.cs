using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Hurt_Nova : MonoBehaviour
    
{
public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova") && !Input.GetKey(KeyCode.Space))
        {
            Debug.Log("The knights hit you.");
            Player_Manager.health -= 5;
            player.GetComponent<Animator>().SetTrigger("isHurt");

        }



    }
}
