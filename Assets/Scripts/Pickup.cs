using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    ScoreScript sm;

    void Start() 
    {
        sm = FindObjectOfType<ScoreScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        { 
            sm.score++;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
}