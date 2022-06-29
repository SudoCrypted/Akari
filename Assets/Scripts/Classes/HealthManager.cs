using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager
{
    public Character Data;
    public float MaxHealth;
    public float CurrentHealth;
    float Threshold;

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
        if (Input.GetKeyDown("l"))
        {
            CurrentHealth -= Amount;
            CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
            Debug.Log(CurrentHealth);
        }
    }
}
