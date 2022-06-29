using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager
{
    public Character Data;
    public float MaxHealth;
    public float CurrentHealth;
    float Threshold;
    public bool isDead = false;

    public HealthManager() // constructor
    {
        Data = new Character();
    }

    public void GainHealth(float Amount)
    {
        if (Input.GetKeyDown("g"))
        {
            CurrentHealth += Amount;
            CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
            Debug.Log(CurrentHealth);
        }
    }

    public void LoseHealth(float Amount)
    {
        CurrentHealth -= Amount;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        Debug.Log(CurrentHealth);
        

        if (CurrentHealth <= 0)
        DeathSequence();
    }

    public void DeathSequence()
    {
        isDead = true;
        Debug.Log("Death:" + isDead);
    }
}
