using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
//    private ParticleSystem sparkle;
    public AudioSource collectSound;
    private void Start()
    {
//        sparkle.Play(false);
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Fire"))
        {
            collectSound.Play();
            keepScore.Score += 100;
            Destroy(gameObject);
            //sparkle.Play(true);
        }
    }
}
