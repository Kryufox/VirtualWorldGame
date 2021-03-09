using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMushrooms : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter (Collider other)
    {
        collectSound.Play();
        ScoringSystem.TheScore += 1;
       Destroy(gameObject);
    }
}
