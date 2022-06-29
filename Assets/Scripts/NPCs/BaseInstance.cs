using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInstance : MonoBehaviour
{

    public Character Base;
    HealthManager health = new HealthManager();

    // Start is called before the first frame update
    public void Start()
    {
        Base = new Character();
        Base.Type = "Base";
        Base.Biome = "Winter";
        Base.Health = 100.0f;
        Base.rarity = 0.6f;

        health.MaxHealth = Base.Health;
        health.CurrentHealth = Base.Health;
    }

    // Update is called once per frame
    void Update()
    {
        health.GainHealth(10.0f);
        health.LoseHealth(10.0f);
    }
}
