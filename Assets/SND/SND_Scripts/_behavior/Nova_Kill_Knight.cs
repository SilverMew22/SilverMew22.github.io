using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_Kill_Knight : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Knight") && (Input.GetButton("Space")))
        {
            collectSound.Play();
            keepScore.Score += 100;
            Destroy(gameObject);
            Debug.Log("Nova hit a knight...");
        }
    }
}
