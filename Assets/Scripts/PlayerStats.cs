using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int health = 100; 
    public int speed = 10;
    public int attackSpeed = 10;
    public int attackDamage = 10;
    public int bulletSpeed = 10;

    public int totalExperience = 0;
    public int experience = 0;
    public int playerLevel = 1;
    public decimal levelUpMultiplyer = 1.25m;
    public decimal experienceThreshold = 100; 

    public void AddExperience(int amount)
    {
        experience += amount;
        Debug.Log(experience + "/" + experienceThreshold);
    }

    public void LevelUp()
    {
        if (experience >= experienceThreshold)
        {
            //temporary level up sequence: add here
            //scale experience threshold by a certain number; increase number scaled by every x levels 
            playerLevel += 1;
            Debug.Log("Level Up:" + playerLevel);
            experienceThreshold *= levelUpMultiplyer;
            totalExperience += experience;
            experience = 0; 
            
            
        }
    }

    public void Update()
    {
        LevelUp();
    }


}
