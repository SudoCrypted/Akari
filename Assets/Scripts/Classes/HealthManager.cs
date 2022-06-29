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
        Threshold = Mathf.Clamp(CurrentHealth, 0, MaxHealth);

        Debug.Log(Threshold);
    }

    public void GainHealth(float Amount)
    {
    }
}
