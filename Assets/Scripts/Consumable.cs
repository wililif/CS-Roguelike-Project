using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
    
{
    //change to increase for other enemies/time passed?
    public int experienceGain = 10; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();

            if (playerStats != null )
            {
                playerStats.AddExperience(experienceGain);

                Debug.Log("Player stats updated.");
            }
            Destroy(gameObject);
        }

    }
}
